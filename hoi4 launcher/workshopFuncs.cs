using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using Ionic.Zip;

namespace hoi4_launcher
{
    public partial class Form1 : Form
    {
        public string[] replaceDescriptorPath(string[] lines, string path, bool isArchived = false)
        {
            List<string> toRet = new List<string>();
            bool hasPath = false;

            string[] myLines = lines;
            string myPath = null;

            if (isArchived)
            {
                using (ZipFile zip = ZipFile.Read(path))
                {
                    ZipEntry e = zip["descriptor.mod"];

                    var x = e.OpenReader();

                    byte[] bytes = new byte[x.Length];
                    x.Read(bytes, 0, (int)x.Length);

                    myLines = Encoding.Default.GetString(bytes).Split('\n');
                    myPath = Path.GetFullPath(path).Replace("\\", "/");
                }
            }
            else
            {
                myPath = Path.GetFullPath(path).Replace("\\", "/");
            }

            foreach (string line in myLines)
            {
                if (contains(line, "archive") && !contains(line, "replace_path"))
                {
                    toRet.Add($"archive=\"{myPath}\"");
                    hasPath = true;
                }
                else if (contains(line, "path") && !contains(line, "replace_path"))
                {
                    toRet.Add($"path=\"{myPath}\"");
                    hasPath = true;
                }
                else
                {
                    toRet.Add(line);
                }
            }

            if (!hasPath)
            {
                toRet.Add($"path=\"{myPath}\"");
            }

            return toRet.ToArray();
        }

        private void reload_workshop_mods_button_Click(object sender, System.EventArgs e)
        {
            // D:\Program Files\steamapps\workshop\content\394360

            int count = 0;

            try
            {
                foreach (string directory in Directory.GetDirectories(workshopLocation))
                {
                    try
                    {
                        // get .mod file

                        string[] folders = Directory.GetFiles(directory);
                        bool isArchived = false;

                        string[] newDescriptor = null;

                        foreach (string fName in folders)
                        {
                            if (contains(fName, ".zip"))
                            {
                                Console.WriteLine("lolol");
                                isArchived = true;
                                newDescriptor = replaceDescriptorPath(null, fName, isArchived: true);
                            }
                        }

                        if (!isArchived)
                        {
                            newDescriptor = replaceDescriptorPath(File.ReadAllLines(directory + "/descriptor.mod"), directory);
                        }

                        File.WriteAllLines($"{folderLocation}/mod/ugc_{directory.Split(Path.DirectorySeparatorChar).Last()}.mod", newDescriptor);
                        count++;
                    }
                    catch (ArgumentException error)
                    {
                        MessageBox.Show($"{error.ParamName}\n{error.Message}");
                    }
                }
            }
            catch
            {

            }

            loadMods();

            MessageBox.Show($"Reloaded {count} mod(s).");
        }
    }
}

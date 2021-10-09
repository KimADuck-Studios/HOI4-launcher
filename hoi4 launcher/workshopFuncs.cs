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

namespace hoi4_launcher
{
    public partial class Form1 : Form
    {
        public string[] replaceDescriptorPath(string[] lines, string path)
        {
            List<string> toRet = new List<string>();
            bool hasPath = false;
            string myPath = Path.GetFullPath(path).Replace("\\", "/");

            foreach (string line in lines)
            {
                if (contains(line, "path") && !contains(line, "replace_path"))
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

                        string[] newDescriptor = replaceDescriptorPath(File.ReadAllLines(directory + "/descriptor.mod"), directory);

                        File.WriteAllLines($"{folderLocation}/mod/ugc_{directory.Split(Path.DirectorySeparatorChar).Last()}.mod", newDescriptor);
                        count++;
                    }
                    catch
                    {

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

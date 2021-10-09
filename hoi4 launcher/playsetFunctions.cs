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
        public void loadPlayset()
        {
            if (File.Exists("settings/.playset"))
            {
                string[] content = File.ReadAllLines("settings/.playset");

                foreach (string line in content)
                {
                    try
                    {
                        char[] x = "##~~##".ToArray<char>();

                        string[] s = line.Split(x);

                        object referenceObj = new mod(s[0], s[6]);

                        enabled_mods_listbox.Items.Add(referenceObj);
                    }
                    catch
                    {
                        // MessageBox.Show($"Invalid mod found in saved playset file: '{line}'.");
                    }
                }
            }
        }

        public void savePlayset()
        {
            if (!File.Exists("settings/.playset"))
            {
                var x = File.Create("settings/.playset");
                x.Close();
            }

            List<string> ls = new List<string>();

            foreach (mod mod in enabled_mods_listbox.Items)
            {
                ls.Add($"{mod.myModName}##~~##{mod.myLocation}");
            }

            File.WriteAllLines("settings/.playset", ls);
        }

        public void loadPlaysets()
        {
            string[] playsetFiles = null;

            try
            {
                playsetFiles = Directory.GetFiles("settings/playsets/");

                foreach (string fname in playsetFiles)
                {
                    string[] mods = File.ReadAllLines(fname);

                    List<mod> modsList = new List<mod>();

                    foreach (string line in mods)
                    {
                        char[] x = "##~~##".ToArray<char>();

                        string[] s = line.Split(x);

                        modsList.Add(new mod(s[0], s[6]));
                    }

                    HOI4_playset_lisbox.Items.Add(new playset(Path.GetFileNameWithoutExtension(fname), modsList.ToArray()));
                }
            }
            catch
            {
                Directory.CreateDirectory("settings/playsets/");
            }
        }

        private void create_new_playset_button_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> vs = new List<string>();
                foreach (mod m in enabled_mods_listbox.Items)
                {
                    vs.Add($"{m.myModName}##~~##{m.myLocation}");
                }

                Directory.CreateDirectory("settings/playsets/");
                File.WriteAllLines($"settings/playsets/{playset_name_textbox.Text}.txt", vs);
                loadPlaysets();
            }
            catch { }
        }

        private void load_playset_button_Click(object sender, EventArgs e)
        {
            try
            {
                playset ps = (playset)HOI4_playset_lisbox.SelectedItem;
                enabled_mods_listbox.Items.Clear();

                foreach (mod mod in ps.mods)
                {
                    enabled_mods_listbox.Items.Add(mod);
                }

            }
            catch { }
        }
    }
}

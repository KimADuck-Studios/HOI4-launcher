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

        public void init()
        {
            try
            {
                cmdArgs_textbox.Text = File.ReadAllText("settings/.cmdargs");
            }
            catch
            {

            }

            // gets location of the hoi4 folder
            if (File.Exists("settings/.ini"))
            {
                ini = new IniFile("settings/.ini");

                if (ini.KeyExists("hoi4location"))
                {
                    folderLocation = ini.Read("hoi4location"); // gets location
                }
                else
                {
                    getLocationOfFolder(); // file exists, but location not set
                }

                if (ini.KeyExists("exelocation"))
                {
                    exeLocation = ini.Read("exelocation"); // gets location
                }
                else
                {
                    getExeLoc(); // file exists, but location not set
                }

                if (ini.KeyExists("workshopFolder"))
                {
                    workshopLocation = ini.Read("workshopFolder"); // gets location
                }
                else
                {
                    getWorkshopLoc(); // file exists, but location not set
                }

                hoi4_exe_location_textbox.Text = exeLocation;
                hoi4_location_textbox.Text = folderLocation;
            }
            else
            {
                // file doesnt exist, so make new folder
                Directory.CreateDirectory("settings");

                ini = new IniFile("settings/.ini");

                getLocationOfFolder();
                getExeLoc(); // file exists, but location not set
            }

            loadMods(false);

            loadPlayset();

            reloadSelectionBox();

            loadDLC();
        }

        public void getLocationOfFolder()
        {
            MessageBox.Show(loc1);

            folderBrowserDialog1.ShowDialog();

            folderLocation = folderBrowserDialog1.SelectedPath;

            hoi4_location_textbox.Text = folderLocation;

            ini.Write("hoi4location", folderLocation);

            loadMods(true);
        }

        public bool contains(string checkingAgainst, string checkingFor)
        {
            return checkingAgainst.IndexOf(checkingFor, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        public void reloadSelectionBox(string filter = "")
        {
            List<mod> allMods = new List<mod>();

            ListBox[] x = { allMods_listbox, enabled_mods_listbox };

            foreach (ListBox l in x)
            {
                foreach (object o in l.Items)
                {
                    bool isAllMods = (l == allMods_listbox);

                    mod thisMod = (mod)o;


                    if (filter == "")
                    {
                        if (isAllMods)
                        {
                            allMods.Add((mod)o);
                        }
                    }
                    else
                    {
                        if (contains(thisMod.myModName, filter))
                        {
                            if (isAllMods)
                            {
                                allMods.Add((mod)o);
                            }
                        }
                    }
                }
            }

            allMods_listbox.Items.Clear();

            loadListBox(allMods, allMods_listbox);
        }

        public void loadListBox(List<mod> modsToLoad, ListBox listBox)
        {
            foreach (mod m in modsToLoad)
            {
                listBox.Items.Add(m);
            }
        }

        public void getExeLoc()
        {
            MessageBox.Show(loc2);

            openFileDialog1.ShowDialog();

            exeLocation = openFileDialog1.FileName;

            hoi4_exe_location_textbox.Text = exeLocation;

            ini.Write("exelocation", exeLocation);
        }

        public void getWorkshopLoc()
        {
            MessageBox.Show(loc3);

            folderBrowserDialog1.ShowDialog();

            workshopLocation = folderBrowserDialog1.SelectedPath;

            workshop_folder_textbox.Text = workshopLocation;

            ini.Write("workshopFolder", workshopLocation);
        }

        private void hoi4_exe_location_button_Click(object sender, EventArgs e)
        {
            getExeLoc();
        }
    }
}

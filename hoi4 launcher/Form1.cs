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
        // localisation
        string loc1 = "This is the folder in your documents directory, it should contain folders called 'savegames' and 'mod'. It should be called 'Hearts of Iron IV'.";
        string loc2 = "The location of 'hoi4.exe', this will be in your 'steamapps/common/Hearts of Iron IV' directory.";

        string err1 = "Error #1: could not find mod folder. Please ensure the folder you have selected is selected.";

        // variables
        string folderLocation = "";
        string exeLocation = "";
        IniFile ini;
        //Dictionary<string, string> mods;
        //Dictionary<string, string> enabledMods;
        List<dlc> dlcs;

        public Form1()
        {
            InitializeComponent();
            init();
            loadPlaysets();

        }

        public void init()
        {
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

        public void loadMods(bool resetModList = true)
        {
            // get all files in mod folder

            string[] ugcFiles = { };

            try
            {
                ugcFiles = Directory.GetFiles($"{folderLocation}/mod");
            }
            catch
            {
                MessageBox.Show(err1); // folder doesn't exist
                return;
            }

            if (resetModList)
            {
                allMods_listbox.Items.Clear();
                enabled_mods_listbox.Items.Clear();
            }

            foreach (string fName in ugcFiles)
            {
                allMods_listbox.Items.Add(new mod(getModName(fName), fName));
            }
        }

        public bool contains(string checkingAgainst, string checkingFor)
        {
            return checkingAgainst.IndexOf(checkingFor, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        public void reloadSelectionBox(string filter = "")
        { 
            List<mod> enabledMods = new List<mod>();
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
                        else
                        {
                            enabledMods.Add((mod)o);
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
                            else
                            {
                                enabledMods.Add((mod)o);
                            }
                        }
                    }
                }
            }

            allMods_listbox.Items.Clear();
            enabled_mods_listbox.Items.Clear();

            loadListBox(enabledMods, enabled_mods_listbox);
            loadListBox(allMods, allMods_listbox);
        }

        public void loadListBox(List<mod> modsToLoad, ListBox listBox)
        {
            foreach (mod m in modsToLoad)
            {
                listBox.Items.Add(m);
            }
        }

        public string getModName(string fName)
        {
            bool inDep = false;

            foreach (string line in File.ReadAllLines(fName))
            {
                if (contains(line, "dependencies"))
                {
                    inDep = true;
                }

                if (inDep && contains(line, "}")) { inDep = false; }

                if (contains(line, "name") && !inDep)
                {
                    return line.Split('=')[1].Trim().Replace("\"", "");
                }
            }

            return null;
        }

        private void hoi4_mod_location_button_Click(object sender, EventArgs e)
        {
            getLocationOfFolder();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loadMods();

            reloadSelectionBox(filter_mods_textbox.Text);
        }

        private void add_selected_mod_button_Click(object sender, EventArgs e)
        {
            if (allMods_listbox.SelectedItem == null) { return; }

            try
            {
                object toAdd = allMods_listbox.SelectedItem;
                enabled_mods_listbox.Items.Add(toAdd);

                reloadSelectionBox();

                savePlayset();
            }
            catch
            {

            }
        }

        private void remove_selected_mod_button_Click(object sender, EventArgs e)
        {
            if (enabled_mods_listbox.SelectedItem == null) { return; }

            object toRemove = enabled_mods_listbox.SelectedItem;
            enabled_mods_listbox.Items.Remove(toRemove);

            reloadSelectionBox();

            savePlayset();
        }

        private void remove_all_mods_button_Click(object sender, EventArgs e)
        {
            enabled_mods_listbox.Items.Clear();

            reloadSelectionBox();

            savePlayset();
        }

        private void launch_game_button_Click(object sender, EventArgs e)
        {
            writeJson();
            var proc = System.Diagnostics.Process.Start(exeLocation);
        }

        private void launch_debug_button_Click(object sender, EventArgs e)
        {
            writeJson();
            var proc = System.Diagnostics.Process.Start(exeLocation, "-debug");
        }

        public void getExeLoc()
        {
            MessageBox.Show(loc2);

            openFileDialog1.ShowDialog();

            exeLocation = openFileDialog1.FileName;

            hoi4_exe_location_textbox.Text = exeLocation;

            ini.Write("exelocation", exeLocation);
        }

        private void hoi4_exe_location_button_Click(object sender, EventArgs e)
        {
            getExeLoc();
        }
    
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
    
        public void loadDLC()
        {
            dlcs = new List<dlc>();

            string[] content = new string[0] { };

            if (File.Exists("settings/.dlc"))
            {
                content = File.ReadAllLines("settings/.dlc");

                foreach (string line in content)
                {

                }
            }

            List<dlc> DLCs = getDLCs();

            HOI4_all_dlc_listbox.Items.Clear();

            foreach (dlc dlc in DLCs)
            {
                if (isDlcInList(dlc, content)) { hoi4_enabled_dlc_listbox.Items.Add(dlc); }

                HOI4_all_dlc_listbox.Items.Add(dlc);
            }
        }

        public bool isDlcInList(dlc dlc, string[] names)
        {
            if (names.Length == 0) { return false; }
            return names.Contains(dlc.myDlcName);
        }

        public List<dlc> getDLCs()
        {
            string[] folders = Directory.GetDirectories(Path.GetDirectoryName(exeLocation) + "\\dlc");
            List<dlc> toRet = new List<dlc>();

            foreach (string folder in folders)
            {
                try
                {
                    string[] folderArray = folder.Split('\\');

                    string dlc = folderArray[folderArray.Length - 1];
                    string dlcNum = dlc.Split('_')[0];

                    string fileLoc = $"dlc/{dlc}/{dlcNum}.dlc";

                    toRet.Add( new dlc( getModName( Path.GetDirectoryName(exeLocation) + "/" + fileLoc).Trim('"'), fileLoc ) );
                }
                catch
                {

                }
            }

            return toRet;
        }
    
        public void writeJson()
        {
            string json = "{\"enabled_mods\":[MODS_HERE],\"disabled_dlcs\":[DISABLED_DLC_HERE]}";

            if (!File.Exists(folderLocation + "/dlc_load.json"))
            {
                var x = File.Create(folderLocation + "/dlc_load.json");
                x.Close();
            }

            string disDLCs = "";
            string enabledModsStringBuilder = "";

            foreach (object o in HOI4_all_dlc_listbox.Items)
            {
                if (!hoi4_enabled_dlc_listbox.Items.Contains(o))
                {
                    dlc d = (dlc)o;

                    disDLCs += $"\"{d.myLocation}\",";
                }
            }

            foreach (mod mod in enabled_mods_listbox.Items)
            {
                enabledModsStringBuilder += $"\"{mod.myLocation}\",";
            }

            try
            {
                enabledModsStringBuilder = enabledModsStringBuilder.Remove(enabledModsStringBuilder.Length - 1, 1);
            }
            catch
            {

            }
            try
            {
                disDLCs = disDLCs.Remove(disDLCs.Length - 1, 1);
            }
            catch
            {

            }

            json = json.Replace("MODS_HERE", enabledModsStringBuilder);

            json = json.Replace("DISABLED_DLC_HERE", disDLCs);

            File.WriteAllText(folderLocation + "/dlc_load.json", json);
        }

        private void HOI4_add_dlc_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!hoi4_enabled_dlc_listbox.Items.Contains(HOI4_all_dlc_listbox.SelectedItem))
                {
                    hoi4_enabled_dlc_listbox.Items.Add(HOI4_all_dlc_listbox.SelectedItem);
                }

                saveDLC();
            }
            catch
            {

            }
        }

        public void saveDLC()
        {
            List<string> toWrite = new List<string>();

            foreach (object i in hoi4_enabled_dlc_listbox.Items)
            {
                var thisDlc = (dlc)i;
                toWrite.Add(thisDlc.myDlcName);
            }

            File.WriteAllLines("settings/.dlc", toWrite);
        }

        private void HOI4_remove_dlc_button_Click(object sender, EventArgs e)
        {
            try
            {
                hoi4_enabled_dlc_listbox.Items.Remove(hoi4_enabled_dlc_listbox.SelectedItem);

                saveDLC();
            }
            catch
            {

            }
        }

        private void HOI4_enable_all_dlc_button_Click(object sender, EventArgs e)
        {
            hoi4_enabled_dlc_listbox.Items.Clear();
            foreach (object o in HOI4_all_dlc_listbox.Items)
            {
                hoi4_enabled_dlc_listbox.Items.Add(o);
            }

            saveDLC();
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
            catch
            {

            }
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
            catch
            {
            }
        }
    }
}
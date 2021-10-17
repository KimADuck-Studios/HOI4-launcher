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
                // enabled_mods_listbox.Items.Clear();
            }

            foreach (string fName in ugcFiles)
            {
                allMods_listbox.Items.Add(new mod(getModName(fName), fName));
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

                if ((contains(line, "name=") || contains(line, "name =")) && !inDep)
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
            loadMods(true);

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

        private void create_new_mod_button_Click(object sender, EventArgs e)
        {
            try
            {
                string modName = new_mod_name_textbox.Text;
                string boiler = "version=\"0.1\"\ntags = {\n\n}\nname = \"MOD_NAME\"\npath = \"MOD_PATH\"";
                // = File.ReadAllText("settings/.modBoilerPlate");

                string toWrite = boiler.Replace("MOD_NAME", modName);
                string myfolderLocation = folderLocation.Replace("\\", "\\\\");

                toWrite = toWrite.Replace("MOD_PATH", myfolderLocation + $"\\\\mod\\\\{modName}");

                File.WriteAllText(myfolderLocation + $"/mod/{modName}.mod", toWrite);
                Directory.CreateDirectory(myfolderLocation + $"/mod/{modName}");

                File.WriteAllText(myfolderLocation + $"/mod/{modName}/descriptor.mod", toWrite);

                new_mod_name_textbox.Text = "";

                reloadSelectionBox();
            }
            catch
            {

            }
        }
    }
}

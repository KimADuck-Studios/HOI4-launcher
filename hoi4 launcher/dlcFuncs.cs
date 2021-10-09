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

                    toRet.Add(new dlc(getModName(Path.GetDirectoryName(exeLocation) + "/" + fileLoc).Trim('"'), fileLoc));
                }
                catch
                {

                }
            }

            return toRet;
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
    }
}

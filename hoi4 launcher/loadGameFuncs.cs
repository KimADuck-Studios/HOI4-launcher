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
    }
}

using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace hoi4_launcher
{
    public partial class Form1 : Form
    {
        // localisation
        string loc1 = "You should now select the folder called 'Hearts of Iron IV', this will usually be located in your documents folder, in '[user]/Documents/Paradox Interactive/'. (This folder should contain a 'mod' folder and a 'savegames' folder).";
        string loc2 = "You should now select the HOI4.exe file, which will usually be located in your 'steamapps/common/Hearts of Iron IV' directory.";
        string loc3 = "You should now select the folder containing your downloaded mods. This will usually be located 'steamapps/workshop/content/394360'.";

        string err1 = "Error #1: could not find mod folder. Please ensure the folder you have selected is selected.";

        // variables
        string folderLocation = "";
        string exeLocation = "";
        string workshopLocation = "";
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

        private void playset_help_button_Click(object sender, System.EventArgs e)
        {
            string toDisplay = "Playsets:\n" +
                "Playsets are a feature allowing you to create groups of mods, so you can have for example, a playset for " +
                "vanilla HOI, or a playset for Kaiserreich, etc.\n\n" +
                "How to use playsets:\n" +
                "-Start by enabling the mods you want in your new playset. " +
                "Then you enter the name of your new playset in the textbox, and press 'Create new playset'.\n\n" +
                "-To load a playset, select it from the list, so it is backlit blue, and press 'Load selected playlist'.\n\n" +
                "-To update a playlist, load it, then make the changes you want in the main area of the launcher. When you " +
                "are done, press 'Update Current Playlist'.";

            MessageBox.Show(toDisplay);
        }
    }
}
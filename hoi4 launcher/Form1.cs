using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace hoi4_launcher
{
    public partial class Form1 : Form
    {
        // localisation
        string loc1 = "This is the folder in your documents directory, it should contain folders called 'savegames' and 'mod'. It should be called 'Hearts of Iron IV'.";
        string loc2 = "The location of 'hoi4.exe', this will be in your 'steamapps/common/Hearts of Iron IV' directory.";
        string loc3 = "Please select the directory which contains the downloaded workshop mods. This should be in 'steamapps/workshop/content/394360'.";

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
    }
}
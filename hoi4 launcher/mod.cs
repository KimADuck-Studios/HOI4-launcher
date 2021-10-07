using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace hoi4_launcher
{
    public class mod
    {
        public string myModName;
        public string myLocation;

        public mod(string ModName, string location)
        {
            this.myModName = ModName;
            string fName = Path.GetFileName(location);
            this.myLocation = $"mod/{fName}";
        }

        public override string ToString()
        {
            return this.myModName;
        }
    }
}

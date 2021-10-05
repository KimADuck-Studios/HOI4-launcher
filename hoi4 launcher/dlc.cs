using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoi4_launcher
{
    public class dlc
    {
        public string myDlcName;
        public string myLocation;

        public dlc(string dlcName, string location)
        {
            this.myDlcName = dlcName;
            this.myLocation = location;
        }

        public override string ToString()
        {
            return this.myDlcName;
        }
    }
}

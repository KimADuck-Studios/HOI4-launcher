using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoi4_launcher
{
    public class playset
    {
        public mod[] mods;
        public string name;

        public playset(string playsetname, mod[] myMods)
        {
            this.mods = myMods;
            this.name = playsetname;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}

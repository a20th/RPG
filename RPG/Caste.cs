using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Caste
    {
        public int Smod { get; private set; }
        public int Dmod { get; private set; }
        public int Imod { get; private set; }
        public int Cmod { get; private set; }
        public int Lmod { get; private set; }
        public int S { get; }
        public int D { get; }
        public int I { get; }
        public int C { get; }
        public int L { get; }

        /*  Használható itemek :( */

        public Caste(int smod, int dmod, int imod, int cmod, int lmod, int armor, int s, int d, int i, int c, int l)
        {
            Smod = smod;
            Dmod = dmod;
            Imod = imod;
            Cmod = cmod;
            Lmod = lmod;
            S = s;
            D = d;
            I = i;
            C = c;
            L = l;
        }

        
    }
}

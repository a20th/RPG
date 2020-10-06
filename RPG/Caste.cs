using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Caste
    {
        public double Smod { get; private set; }
        public double Dmod { get; private set; }
        public double Imod { get; private set; }
        public double Cmod { get; private set; }
        public double Lmod { get; private set; }
        public int S { get; }
        public int D { get; }
        public int I { get; }
        public int C { get; }
        public int L { get; }
        public string Name { get; private set; }

        /*  Használható itemek :( */

        public Caste(string name, double smod, double dmod, double imod, double cmod, double lmod, int s, int d, int i, int c, int l)
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
            Name = name;
        }

        
    }
}

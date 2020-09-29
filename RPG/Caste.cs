using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Caste
    {
        protected int smod;
        protected int dmod;
        protected int imod;
        protected int cmod;
        protected int lmod;

        /*  Használható itemek :( */

        public Caste(int smod, int dmod, int imod, int cmod, int lmod)
        {
            this.smod = smod;
            this.dmod = dmod;
            this.imod = imod;
            this.cmod = cmod;
            this.lmod = lmod;
        }
    }
}

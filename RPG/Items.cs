using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    abstract class Item
    {
        protected string[] useableSlot;
        protected int id;

        protected int stre;
        protected int dext;
        protected int inte;
        protected int cons;
        protected int luck;

        protected Caste usableBy;

        protected Item(string[] useableSlot, int id, int stre, int dext, int inte, int cons, int luck, Caste usableBy)
        {
            this.useableSlot = useableSlot;
            this.id = id;
            this.stre = stre;
            this.dext = dext;
            this.inte = inte;
            this.cons = cons;
            this.luck = luck;
            this.usableBy = usableBy;
        }
    }
}

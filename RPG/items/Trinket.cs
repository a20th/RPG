using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.items
{
    class Trinket : Item
    {
        protected new static string[] useableSlot = { "Trinket1", "Trinket2" };

        public Trinket(int id, int stre, int dext, int inte, int cons, int luck, Caste usableBy) : base(useableSlot, id, stre, dext, inte, cons, luck, usableBy)
        {
        }
    }
}

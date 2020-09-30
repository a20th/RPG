using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Weapon : Item
    {
        protected double dmg;
        protected new static string[] useableSlot = {"Weapon1", "Weapon2"};
        public Weapon(int id, int stre, int dext, int inte, int cons, int luck, Caste usableBy, double dmg ) : base(useableSlot, id, stre, dext, inte, cons, luck, usableBy)
        {
            this.dmg = dmg;
        }
    }
}

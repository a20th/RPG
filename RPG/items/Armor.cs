using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.items
{

    abstract class Armor : Item
    {
        private double armor;
        public Armor(string name, int id, int stre, int dext, int inte, int cons, int luck, Caste usableBy, double armor) : base(name, id, stre, dext, inte, cons, luck, usableBy)
        {
            this.armor = armor;
        }
    }
}

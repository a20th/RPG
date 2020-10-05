using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.items
{

    abstract class Armor : Item
    {
        private int armor;
        public Armor(string name, int id, int stre, int dext, int inte, int cons, int luck, Caste usableBy, int armor, double price) : base(name, id, stre, dext, inte, cons, luck, usableBy, price)
        {
            this.armor = armor;
        }

        public int Arm { get => armor; }
    }
}

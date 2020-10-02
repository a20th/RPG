using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.items
{
    class Trinket : Item
    {
        public Trinket()
        {
        }

        public Trinket(int id, int stre, int dext, int inte, int cons, int luck, Caste usableBy, string name) : base(name, id, stre, dext, inte, cons, luck, usableBy)
        {
        }

        public override Type CanBePlaced => throw new NotImplementedException();
    }
}

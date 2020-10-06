using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.itemslots;

namespace RPG.Items.Armors
{
    class Helmet : Armor
    {
        //public override Type CanBePlaced { get; } = new HelmetSlot().GetType();

        public Helmet(string name, int id, int stre, int dext, int inte, int cons, int luck, Caste usableBy, int armor, double price) : base(name, id, stre, dext, inte, cons, luck, usableBy, armor, price)
        {
        }

        public Helmet() : base(null, -1, -1, -1, -1, -1, -1, null, -1, -1) { }
        
    }
}

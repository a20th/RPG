using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.itemslots;

namespace RPG.items.armors
{
    class Foot : Armor
    {
        public override Type CanBePlaced { get; } = new FootSlot().GetType();

        public Foot(string name, int id, int stre, int dext, int inte, int cons, int luck, Caste usableBy, double armor) : base(name, id, stre, dext, inte, cons, luck, usableBy, armor)
        {
        }
        public Foot() : base(null, -1, -1, -1, -1, -1, -1, null, -1)
        {
            //Típuslekérdezéshez
        }
    }
}

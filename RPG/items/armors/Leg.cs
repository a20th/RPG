using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.itemslots;

namespace RPG.items.armors
{
    class Leg : Armor
    {
       /* private readonly Type canBePlaced = new LegSlot().GetType();
         */
        public override Type CanBePlaced { get; } = new LegSlot().GetType();

        public Leg(string name, int id, int stre, int dext, int inte, int cons, int luck, Caste usableBy, double armor) : base(name, id, stre, dext, inte, cons, luck, usableBy, armor)
        {
        }
        public Leg() : base(null, -1, -1, -1, -1, -1, -1, null, -1)
        {
            //Típuslekérdezéshez
        }
    }
}

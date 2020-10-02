using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.itemslots
{
    class WeaponSlot : ItemSlot
    {
        public WeaponSlot(Weapon l) : base(l)
        {

        }
        public WeaponSlot() : base(null)
        {

        }

        public override Type UseableItem { get; } = new Weapon().GetType();
        public override Item slotItem { get; set; }
    }
}

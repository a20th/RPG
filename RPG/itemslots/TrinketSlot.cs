using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.items;

namespace RPG.itemslots
{
    class TrinketSlot : ItemSlot
    {
        public TrinketSlot(Trinket l) : base(l)
        {

        }
        public TrinketSlot() : base(null)
        {

        }

        public override Type UseableItem { get; } = new Trinket().GetType();
        public override Item slotItem { get; set; }
    }
}

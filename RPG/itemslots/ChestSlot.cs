using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.items.armors;

namespace RPG.itemslots
{
    class ChestSlot : ItemSlot
    {
        public ChestSlot(Chest item) : base(item)
        {
        }

        public ChestSlot() : base(null)
        {

        }

        public override Type UseableItem { get; } = new Chest().GetType();
        public override Item slotItem { get; set; }
    }
        
}

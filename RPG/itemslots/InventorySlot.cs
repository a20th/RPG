using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Items;

namespace RPG.itemslots
{
    class InventorySlot : ItemSlot
    {
        public InventorySlot() : base(null)
        {
        }

        public InventorySlot(Item item) : base(item)
        {

        }

        public override Type UseableItem { get; } = new Trinket().GetType().BaseType;
        public override Item slotItem { get; set; }

        public override string ToString()
        {
            if(slotItem == null)
            {
                return "InventorySlot: *Empty*";
            }
            return "InventorySlot: " + slotItem.Name;
        }
    }
}

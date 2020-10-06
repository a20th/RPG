using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Items.Armors;

namespace RPG.itemslots
{
    class FootSlot : ItemSlot
    {
        public FootSlot() : base(null)
        {
        }

        public FootSlot(Foot item) : base(item)
        {
            
        }

        public override Type UseableItem { get; } = new Foot().GetType();
        public override Item slotItem { get ; set; }

        public override string ToString()
        {
            if (slotItem == null)
            {
                return "FootSlot: *Empty*";
            }
            return "FootSlot: " + slotItem.Name;
        }
    }
        
}

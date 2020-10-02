using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.items.armors;

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
    }
        
}

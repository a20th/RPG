using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.items.armors;

namespace RPG.itemslots
{
    class LegSlot : ItemSlot
    {
        
        
        public LegSlot(Leg l) : base(l)
        {
            
        }
        public LegSlot() : base(null)
        {

        }

        public override Type UseableItem { get; } = new Leg().GetType();
        public override Item slotItem { get; set; }
    }
        
}

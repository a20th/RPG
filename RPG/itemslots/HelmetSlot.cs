using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.items.armors;

namespace RPG.itemslots
{
    class HelmetSlot : ItemSlot
    {
        public HelmetSlot(Helmet item) : base(item)
        {
        }

        public HelmetSlot() : base(null)
        {

        }

        public override Type UseableItem { get; } = new Helmet().GetType();
        public override Item slotItem { get; set; }
    }
        
}

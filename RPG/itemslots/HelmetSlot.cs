using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Items.Armors;

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

        public override string ToString()
        {
            if (slotItem == null)
            {
                return "HelmetSlot: *Empty*";
            }
            return "HelmetSlot: " + slotItem.Name;
        }
    }
        
}

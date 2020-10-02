﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.items;

namespace RPG.itemslots
{
    class RingSlot : ItemSlot
    {
        public RingSlot(Ring l) : base(l)
        {

        }
        public RingSlot() : base(null)
        {

        }


        public override Type UseableItem { get; } = new Ring().GetType();
        public override Item slotItem { get; set; }
    }
}

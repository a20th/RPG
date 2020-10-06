using System;

namespace RPG
{
     public abstract class ItemSlot
     {
        public abstract Type UseableItem { get; }
        public abstract Item slotItem { get; set; }

       
        public ItemSlot(Item item)
        {
            slotItem = item;
        }

        public abstract override string ToString();
        
    }
}
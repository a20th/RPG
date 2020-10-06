using RPG.Items;
using RPG.itemslots;
using System;
using System.Collections;

namespace RPG
{
    class InventorySystem : IEnumerable
    {
        public ItemSlot[] Content { get; private set; }
        public double Money { get; private set; }


        private static ItemSlot[] Swap(ItemSlot[] inv, int i1, int i2)
        {            
            Item temp = inv[i1].slotItem;
            inv[i1].slotItem = inv[i2].slotItem;
            inv[i2].slotItem = temp;
            return inv;
        }

        public void ReplaceItem(int i1, int i2)
        {
            if (Content[i1].UseableItem == Content[i2].slotItem.GetType() && Content[i2].UseableItem == Content[i1].slotItem.GetType())
            {
                Content = Swap(Content, i1, i2);
            }
        }

        /*public void ReplaceItem(int i1)
        {
            Type t = Inventory[i1].slotItem.CanBePlaced.GetType();
            List<int> x = new List<int>();
            if (t != Inventory[i1].GetType())
            {
                for (int i = 0; i < Inventory.Length; i++)
                {
                    if (Inventory[i].UseableItem == t && t != new InventorySystem().GetType())
                    {
                        x.Add(i);
                    }
                }
                if (x.Count > 1)
                {
                    //Array.Sort, IComparable implementáció
                }
                Inventory = Swap(Inventory, i1, x[0]);
            }
            else
            {
                for (int i = 0; i < Inventory.Length; i++)
                {
                    if(Inventory[i].GetType() == new InventorySystem().GetType() && Inventory[i].slotItem == null)
                    {
                        Inventory = Swap(Inventory, i1, i);
                    }
                }
            }
        }*/

        public ItemSlot[] Sell(int i1)
        {
            if(Content[i1] != null && Content[i1].slotItem.Price * 0.30  <= Money)
            {
                //pénz eladásból
                Money -= Content[i1].slotItem.Price * 0.30;
                Content[i1].slotItem = null;
                return Content;
            }
            return Content;
        }

        public void Add(Item newItem)
        {
            if (!isInventoryFull())
            {
                bool done = false;
                for (int i = 0; i < Content.Length; i++)
                {
                    if (Content[i].UseableItem == new Trinket().GetType().BaseType && Content[i].slotItem == null && !done)
                    {
                        Content[i].slotItem = newItem;
                        done = true;
                        
                    }
                }
            }
        }

        public void ChangeMoney(double value)
        {
            Money += value;
        }

        private bool isInventoryFull()
        {
            int i = 0;
            foreach (ItemSlot item in Content)
            {
                if(item.slotItem == null)
                {
                    i++;
                }
            }

            if (i == 0)
            {
                return true;
            }
            return false;
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public InventoryEnum GetEnumerator()
        {
            return new InventoryEnum(Content);
        }

        public InventorySystem()
        {
            Content = new ItemSlot[14];
            Content[0] = new HelmetSlot();
            Content[1] = new ChestSlot();
            Content[2] = new LegSlot();
            Content[3] = new FootSlot();
            Content[4] = new WeaponSlot();
            Content[5] = new RingSlot();
            Content[6] = new RingSlot();
            Content[7] = new TrinketSlot();
            Content[8] = new TrinketSlot();
            for (int i = 9; i < 14; i++)
            {
                Content[i] = new InventorySlot();
            }
        }

        public InventorySystem(Item[] items, double money)
        {
            Money = money;
            Content = new ItemSlot[14];
            Content[0] = new HelmetSlot();
            Content[1] = new ChestSlot();
            Content[2] = new LegSlot();
            Content[3] = new FootSlot();
            Content[4] = new WeaponSlot();
            Content[5] = new RingSlot();
            Content[6] = new RingSlot();
            Content[7] = new TrinketSlot();
            Content[8] = new TrinketSlot();
            for (int i = 9; i < 14; i++)
            {
                Content[i] = new InventorySlot();
            }

            for (int i = 0; i < 14; i++)
            {
                Content[i].slotItem = items[i];
                
            }
        }

        /*public static ItemSlot[] InitalizeInventoryentory(Helmet h, Chest c, Leg l, Foot f, Weapon w, Ring r1, Ring r2, Trinket t1, Trinket t2, Item i1, Item i2, Item i3, Item i4, Item i5)
        {
            ItemSlot[] Inventoryentory = new ItemSlot[14];
            Inventoryentory[0] = new HelmetSlot(h);
            Inventoryentory[1] = new ChestSlot(c);
            Inventoryentory[2] = new LegSlot(l);
            Inventoryentory[3] = new FootSlot(f);
            Inventoryentory[4] = new WeaponSlot(w);
            Inventoryentory[5] = new RingSlot(r1);
            Inventoryentory[6] = new RingSlot(r2);
            Inventoryentory[7] = new TrinketSlot(t1);
            Inventoryentory[8] = new TrinketSlot(t2);
            Inventoryentory[9] = new InventoryentorySlot(i1);
            Inventoryentory[10] = new InventoryentorySlot(i2);
            Inventoryentory[11] = new InventoryentorySlot(i3);
            Inventoryentory[12] = new InventoryentorySlot(i4);
            Inventoryentory[13] = new InventoryentorySlot(i5);
            return Inventoryentory;
        }*/



    }
}

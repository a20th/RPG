using RPG.items;
using RPG.items.armors;
using RPG.itemslots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    static class InventoryController
    {

        private static ItemSlot[] Swap(ItemSlot[] inv, int i1, int i2)
        {
            
            Item temp = inv[i1].slotItem;
            inv[i1].slotItem = inv[i2].slotItem;
            inv[i2].slotItem = temp;
            return inv;
        }

        public static ItemSlot[] ReplaceItem(ItemSlot[] inv, int i1, int i2)
        {
            if (inv[i1].UseableItem == inv[i2].slotItem.CanBePlaced && inv[i2].UseableItem == inv[i1].slotItem.CanBePlaced)
            {
                return Swap(inv, i1, i2);
            }
            else
            {
                return inv;
            }
        }

        public static ItemSlot[] ReplaceItem(ItemSlot[] inv, int i1)
        {
            Type t = inv[i1].slotItem.CanBePlaced.GetType();
            List<int> x = new List<int>();
            if (t != inv[i1].GetType())
            {
                for (int i = 0; i < inv.Length; i++)
                {
                    if (inv[i].UseableItem == t && t != new InventorySlot().GetType())
                    {
                        x.Add(i);
                    }
                }
                if (x.Count > 1)
                {
                    //Array.Sort, IComparable implementáció
                }
                return Swap(inv, i1, x[0]);
            }
            else
            {
                for (int i = 0; i < inv.Length; i++)
                {
                    if(inv[i].GetType() == new InventorySlot().GetType() && inv[i].slotItem == null)
                    {
                        return Swap(inv, i1, i);
                    }
                }
                return inv;
            }
        }

        private static ItemSlot[] Sell(ItemSlot[] inv, int i1)
        {
            if(inv[i1] != null)
            {
                //pénz eladásból
                inv[i1].slotItem = null;
                return inv;
            }
            return inv;
        }

        public static ItemSlot[] Add(ItemSlot[] inv, Item newItem)
        {
            if (!isInventoryFull(inv))
            {
                for (int i = 0; i < inv.Length; i++)
                {
                    if (inv[i].GetType() == new InventorySlot().GetType() && inv[i].slotItem == null)
                    {
                        inv[i].slotItem = newItem;
                        return inv;
                    }
                }
            }
            return inv;
        }

        private static bool isInventoryFull(ItemSlot[] inv)
        {
            int i = 0;
            foreach (ItemSlot item in inv)
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

        

        public static ItemSlot[] InitalizeInventory()
        {
            ItemSlot[] inventory = new ItemSlot[14];
            inventory[0] = new HelmetSlot();
            inventory[1] = new ChestSlot();
            inventory[2] = new LegSlot();
            inventory[3] = new FootSlot();
            inventory[4] = new WeaponSlot();
            inventory[5] = new RingSlot();
            inventory[6] = new RingSlot();
            inventory[7] = new TrinketSlot();
            inventory[8] = new TrinketSlot();
            for (int i = 9; i < 15; i++)
            {
                inventory[i] = new InventorySlot();
            }
            return inventory;
        }

        /*public static ItemSlot[] InitalizeInventory(Helmet h, Chest c, Leg l, Foot f, Weapon w, Ring r1, Ring r2, Trinket t1, Trinket t2, Item i1, Item i2, Item i3, Item i4, Item i5)
        {
            ItemSlot[] inventory = new ItemSlot[14];
            inventory[0] = new HelmetSlot(h);
            inventory[1] = new ChestSlot(c);
            inventory[2] = new LegSlot(l);
            inventory[3] = new FootSlot(f);
            inventory[4] = new WeaponSlot(w);
            inventory[5] = new RingSlot(r1);
            inventory[6] = new RingSlot(r2);
            inventory[7] = new TrinketSlot(t1);
            inventory[8] = new TrinketSlot(t2);
            inventory[9] = new InventorySlot(i1);
            inventory[10] = new InventorySlot(i2);
            inventory[11] = new InventorySlot(i3);
            inventory[12] = new InventorySlot(i4);
            inventory[13] = new InventorySlot(i5);
            return inventory;
        }*/



    }
}

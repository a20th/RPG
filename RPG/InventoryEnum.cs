using RPG.itemslots;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class InventoryEnum : IEnumerator
    {
        public ItemSlot[] inv;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        int position = -1;

        public InventoryEnum(ItemSlot[] list)
        {
            inv = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < inv.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public ItemSlot Current
        {
            get
            {
                try
                {
                    return inv[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}

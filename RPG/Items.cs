using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public abstract class Item
    {
        private string name;
        protected int id;

        protected int stre;
        protected int dext;
        protected int inte;
        protected int cons;
        protected int luck;

        protected Caste usableBy;

        public int Stre { get => stre; }
        public int Dext { get => dext; }
        public int Inte { get => inte; }
        public int Cons { get => cons; }
        public int Luck { get => luck; }
        public double Price { get; }
        public string Name { get => name; }

        protected Item(string name, int id, int stre, int dext, int inte, int cons, int luck, Caste usableBy, double price)
        {
            this.name = name;
            this.id = id;
            this.stre = stre;
            this.dext = dext;
            this.inte = inte;
            this.cons = cons;
            this.luck = luck;
            Price = price;
            this.usableBy = usableBy;
        }

        internal Item()
        {

        }

        //public abstract override string ToString();
        
    }
}

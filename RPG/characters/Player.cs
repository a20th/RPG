using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.characters
{
    class Player : Character
    {
        private int xp;
        protected string gender;
        private bool EmptyInventory;

        ItemSlot[] inventory;


        /* Felszerelés rendszer helye */

        public Player(int level, int strength, int dexterity, int intelligence, int constitution, int luck, int xp, string name, Caste caste, string gender, ItemSlot[] inventory) : base(level, strength, dexterity, intelligence, constitution, luck, name, caste)
        {
            this.gender = gender;
            this.xp = xp;
            hpmodifier = 5;
            
            foreach(ItemSlot item in inventory)
            {
                if(item != null)
                {
                    EmptyInventory = false;
                }
            }

            if (EmptyInventory)
            {
                this.inventory = inventory;
            }
            else
            {
                this.inventory = new ItemSlot[12];
            }
            
        }

        public int Xp { get => xp; }

        public int Level { get => calculateLevel(); }
        
        /*private int calculateLevel(int xpmod, int lvl)
        {
            if(xpmod >= 400 + (lvl - 1) * 500){
                Console.WriteLine("ret1");
                return calculateLevel(xpmod - 400 + (lvl - 1) * 500, ++lvl);
            }
            else{
                Console.WriteLine("ret2");
                return lvl;
            }
        }*/

        private int calculateLevel()
        {
            int xpmod = xp;
            int lvl = 1;
            while(xpmod >= 400 + (lvl - 1) * 500)
            {
                xpmod -= 400 + (lvl - 1) * 500;
                lvl++;
            }
            return lvl;
        }


        public new string Name { get => name;
            set {
                //Foglalt név ellenőrzés :(
                name = value;
            }
        }
        
    }
}

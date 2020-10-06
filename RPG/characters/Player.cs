using RPG.Items;
using RPG.Items.Armors;
using RPG.itemslots;
using RPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.characters
{
    class Player : Character
    {
        protected string gender;
        private bool EmptyInventory;
        private int strength;
        private int dexterity;
        private int intelligence;
        private int constitution;
        private int luck;

        /* Felszerelés rendszer helye */

        public Player(int strength, int dexterity, int intelligence, int constitution, int luck, int xp, string name, int armor, Caste caste, string gender, Item[] inv, double money) : base(name, armor, caste)
        {
            this.gender = gender;
            this.strength = strength + 20;
            this.dexterity = dexterity + 20;
            this.intelligence = intelligence + 20;
            this.constitution = constitution + 20;
            this.luck = luck + 20;
            Xp = xp;
            hpmodifier = 5;
            
            foreach(Item item in inv)
            {
                if(item != null)
                {
                    EmptyInventory = false;
                }
            }

            if (EmptyInventory)
            {
                Inventory = new InventorySystem();
            }
            else
            {
                Inventory = new InventorySystem(inv, money);
            }
           
        }

        public int Xp { get; private set; }
        public int Level {
            get {
                int xpmod = Xp;
                int lvl = 1;
                while (xpmod >= 400 + (lvl - 1) * 500)
                {
                    xpmod -= 400 + (lvl - 1) * 500;
                    lvl++;
                }
                return lvl;
            }
        }

        public override double Strength { get => caste.S + strength + calculateStat("str"); }
        public override double Dexterity { get => caste.D + dexterity + calculateStat("dex"); }
        public override double Intelligence { get => caste.I + intelligence + calculateStat("int"); }
        public override double Constitution { get => caste.C + constitution + calculateStat("con"); }
        public override double Luck { get => caste.L + luck + calculateStat("luc"); }
        public override int Armor { get => armor + calculateStat("arm"); }
        
        

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
        }

        private int calculateLevel()
        {
            int xpmod = Xp;
            int lvl = 1;
            while(xpmod >= 400 + (lvl - 1) * 500)
            {
                xpmod -= 400 + (lvl - 1) * 500;
                lvl++;
            }
            return lvl;
        }*/



        public void buyStat(string arg)
        {
            switch (arg)
            {
                case "str":
                    if(Inventory.Money >= (strength - 20) * 0.25)
                    {
                        Inventory.ChangeMoney(-(strength - 20) * 0.25);
                        strength++;
                    }
                    break;

                case "dex":
                    if (Inventory.Money >= (dexterity - 20) * 0.25)
                    {
                        Inventory.ChangeMoney(-(dexterity - 20) * 0.25);
                        dexterity++;
                    }
                    break;

                case "int":
                    if (Inventory.Money >= (intelligence - 20) * 0.25)
                    {
                        Inventory.ChangeMoney(-(intelligence - 20) * 0.25);
                        intelligence++;
                    }
                    break;

                case "con":
                    if (Inventory.Money >= (constitution - 20) * 0.25)
                    {
                        Inventory.ChangeMoney(-(constitution - 20) * 0.25);
                        constitution++;
                    }
                    break;

                case "luc":
                    if (Inventory.Money >= (luck - 20) * 0.25)
                    {
                        Inventory.ChangeMoney((luck - 20) * 0.25);
                        luck++;
                    }
                    break;

                default:
                    break;
            }
        }

        private int calculateStat(string arg)
        {
            int stat = 0;
            switch (arg)
            {
                case "str":
                    foreach(ItemSlot item in Inventory)
                    {
                        if (item.GetType() != new InventorySlot().GetType() && item.slotItem != null)
                        {
                            stat += item.slotItem.Stre;
                        }
                    }
                    return stat;

                case "dex":
                    foreach (ItemSlot item in Inventory)
                    {
                        if (item.GetType() != new InventorySlot().GetType() && item.slotItem != null)
                        {
                            stat += item.slotItem.Dext;
                        }
                    }
                    return stat;

                case "int":
                    foreach (ItemSlot item in Inventory)
                    {
                        if (item.GetType() != new InventorySlot().GetType() && item.slotItem != null)
                        {
                            stat += item.slotItem.Inte;
                        }
                    }
                    return stat;

                case "con":
                    foreach (ItemSlot item in Inventory)
                    {
                        if (item.GetType() != new InventorySlot().GetType() && item.slotItem != null)
                        {
                            stat += item.slotItem.Cons;
                        }
                    }
                    return stat;

                case "luc":
                    foreach (ItemSlot item in Inventory)
                    {
                        if (item.GetType() != new InventorySlot().GetType() && item.slotItem != null)
                        {
                            stat += item.slotItem.Luck;
                        }
                    }
                    return stat;

                case "armor":
                    foreach (ItemSlot item in Inventory)
                    {
                        if (item.GetType() != new InventorySlot().GetType() && item.slotItem.GetType() == new Helmet().GetType().BaseType && item.slotItem != null)
                        {
                            Armor a = item.slotItem as Armor;
                            stat += a.Arm;                        
                        }
                    }
                    return stat;

                default:
                    return 0;     
            }
            
        }

        public override string ToString()
        {
            string text;
            text = Name + ", a " + gender + " " + caste.Name + "\n";
            text +="Strength: " + Strength +" Dexterity: "+ Dexterity + " Intelligence: "+ Intelligence + " Constitution: " +Constitution + " Luck: " + Luck + " Armor: " + Armor + "\n";
            foreach(ItemSlot item in Inventory)
            {
                text += item + "\n";
            }
            return text;
        }

        public new string Name { get => name;
            set {
                //Foglalt név ellenőrzés :(
                name = value;
            }
        }

        public InventorySystem Inventory { get; }
    }
}

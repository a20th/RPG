using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    abstract class Character
    {
        protected int level;
        protected double hpmodifier;
        protected string name;

        protected Caste caste;

        

        protected int armor;

        protected Character(string name, int armor, Caste caste)
        { 
            this.name = name;
            this.caste = caste;
            this.armor = armor;
        }
        

        public virtual double Strength { get => caste.Smod * level * caste.S; }
        public virtual double Dexterity { get =>  caste.D * caste.Dmod * level;  }
        public virtual double Intelligence { get => caste.I * caste.Imod * level;  }
        public virtual double Constitution { get => caste.C * caste.Cmod * level;  }
        public virtual double Luck { get => caste.L * caste.Lmod * level; }
        public double Hitpoints { get => hpmodifier * Constitution * (level + 1); }
        public string Name { get => name;}
        public virtual int Armor { get => armor;  }
    }
}

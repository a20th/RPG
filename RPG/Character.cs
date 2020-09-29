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

        protected int strength;
        protected int dexterity;
        protected int intelligence;
        protected int constitution;
        protected int luck;

        protected Character(int level, int strength, int dexterity, int intelligence, int constitution, int luck, string name, Caste caste)
        {
            this.level = level;
            this.strength = strength;
            this.dexterity = dexterity;
            this.intelligence = intelligence;
            this.constitution = constitution;
            this.luck = luck;
            this.name = name;
            this.caste = caste;
        }

        public double Strength { get => strength; }
        public double Dexterity { get => dexterity;  }
        public double Intelligence { get => intelligence;  }
        public double Constitution { get => constitution;  }
        public double Luck { get => luck;  }
        public double Hitpoints { get => hpmodifier * constitution * (level + 1); }
        public string Name { get => name;}
        
    }
}

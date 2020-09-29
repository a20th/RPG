using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.characters
{
    class Monster : Character
    {
        public Monster(int level, int strength, int dexterity, int intelligence, int constitution, int luck, string name) : base(level, strength, dexterity, intelligence, constitution, luck, name)
        {
            hpmodifier = 3.2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.characters
{
    class Monster : Character
    {
        public Monster(int level, string name, int armor, Caste caste) : base(name, armor, caste)
        {
            hpmodifier = 3.2;
            this.level = level;
        }
    }
}

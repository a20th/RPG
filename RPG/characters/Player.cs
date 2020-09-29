﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.characters
{
    class Player : Character
    {
        private int xp;

        /* Felszerelés rendszer helye */

        public Player(int level, int strength, int dexterity, int intelligence, int constitution, int luck, int xp, string name) : base(level, strength, dexterity, intelligence, constitution, luck, name)
        {
            if(xp == 0)
            {
                getXP(0);
            }
            hpmodifier = 5;
        }

        public int Xp { get => xp; }

        public void getXP(int xp)
        {
            if (this.xp - xp <= 0)
            {
                level++;
                xp = 400 + (level - 1)  * 500;
            }
            else
            {
                this.xp =- xp;
            }
        }

        public void changeName(string name)
        {
            //Azért nem tulajdonság, mert ellenőrizni akarjuk majd hogy ne legyen egyezés.
            this.name = name;
        }
    }
}
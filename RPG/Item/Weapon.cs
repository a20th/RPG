﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Items
{
    class Weapon : Item
    {
        protected double dmg;

        //public override Type CanBePlaced => throw new NotImplementedException();

        public Weapon(int id, int stre, int dext, int inte, int cons, int luck, Caste usableBy, double dmg, string name, double price ) : base(name, id, stre, dext, inte, cons, luck, usableBy, price)
        {
            this.dmg = dmg;
        }

        public Weapon()
        {
        }
    }
}

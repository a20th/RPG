﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Items
{
    class Ring : Item
    {
        public Ring()
        {
        }

        public Ring(int id, int stre, int dext, int inte, int cons, int luck, Caste usableBy, string name, double price) : base(name, id, stre, dext, inte, cons, luck, usableBy, price)
        {

        }

        //public override Type CanBePlaced => throw new NotImplementedException();
    }
}


﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Gum : Item
    {

        public Gum(string slotLocation, string productName, decimal price, string type, int count) : base(slotLocation, productName, price, type, count, "Chew Chew, Yum!")
        {

        }
    }
}

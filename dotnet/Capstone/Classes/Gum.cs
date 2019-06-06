﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Gum : Item
    {
        public string SlotLocation { get;  set; }
        public string ProductName { get;  set; }
        public decimal Price { get;  set; }
        public string Type { get;  set; }
        public string Phrase { get; }

        public Gum(string slotLocation, string productName, decimal price, string type) : base(slotLocation, productName, price, type)
        {
            SlotLocation = slotLocation;
            ProductName = productName;
            Price = price;
            Type = type;
            Phrase = "Chew Chew, Yum!";

        }
    }
}

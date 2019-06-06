﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public abstract class Item
    {
        public string SlotLocation { get; set;}
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }
        public string Phrase { get; }

        public Item(string slotLocation, string productName, decimal price, string type, string phrase)
        {
            SlotLocation = slotLocation;
            ProductName = productName;
            Price = price;
            Type = type;
            Phrase = phrase;
        }

        public string SayPhrase()
        {
            return Phrase;
        }
    }
}

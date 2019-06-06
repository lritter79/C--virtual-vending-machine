﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Item
    {
        public string SlotLocation { get; }
        public string ProductName { get;  }
        public decimal Price { get;  }
        public string Type { get; }
        public string Phrase { get; }
        public int Count { get; protected set; }

        public Item(string slotLocation, string productName, decimal price, string type, string phrase, int count)
        {
            SlotLocation = slotLocation;
            ProductName = productName;
            Price = price;
            Type = type;
            Phrase = phrase;
            Count = count;
        }

        public string SayPhrase()
        {
            return Phrase;
        }

        public void Sale()
        {
            Count--;
        }
    }
}

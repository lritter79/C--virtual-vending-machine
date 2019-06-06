using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Drink : Item
    {
        public string SlotLocation { get;  set; }
        public string ProductName { get;  set; }
        public decimal Price { get;  set; }
        public string Type { get;  set; }
        public string Phrase { get; }

        public Drink(string slotLocation, string productName, decimal price, string type) : base(slotLocation, productName, price, type)
        {
            SlotLocation = slotLocation;
            ProductName = productName;
            Price = price;
            Type = type;
            Phrase = "Glug Glug, Yum!";
        }
    }
}

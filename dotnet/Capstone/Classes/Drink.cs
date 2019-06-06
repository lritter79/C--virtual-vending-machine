using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Drink : Item
    {

        public Drink(string slotLocation, string productName, decimal price, string type, int count) : base(slotLocation, productName, price, type, count, "Glug Glug, Yum!")
        {
        }


    }
}

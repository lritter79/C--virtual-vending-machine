using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Drink : Item
    {

        public Drink(string slotLocation, string productName, decimal price, string type) : base(slotLocation, productName, price, type, "Glug Glug, Yum!")
        {
        }


    }
}

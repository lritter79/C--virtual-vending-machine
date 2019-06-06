using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Chip : Item
    {

        public Chip(string slotLocation, string productName, decimal price, string type) : base(slotLocation, productName, price, type, "Crunch Crunch, Yum!")
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Chip : Item
    {

        public Chip(string slotLocation, string productName, decimal price, string type, int count) : base(slotLocation, productName, price, type, count, "Crunch Crunch, Yum!")
        {
        }
    }
}

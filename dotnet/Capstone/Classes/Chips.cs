using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Chips : Item
    {

        public Chips(string slotLocation, string productName, decimal price, string type) : base(slotLocation, productName, price, type, "Crunch Crunch, Yum!")
        {
        }
    }
}

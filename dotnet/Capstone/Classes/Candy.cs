using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Candy : Item
    {

        public Candy(string slotLocation, string productName, decimal price, string type, int count) : base(slotLocation, productName, price, type, "Munch Munch, Yum!", count)
        {
        }
    }
}

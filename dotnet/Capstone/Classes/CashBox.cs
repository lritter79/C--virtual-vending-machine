using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class CashBox
    {
        public decimal Balance { get; set; }

        public CashBox()
        {
            Balance = 0;
        }

        public void AddBalance(string feed)
        {
            decimal moneyFed = decimal.Parse(feed);
            if (moneyFed >= 0)
            {
                Balance += moneyFed;
            }
        }

        public decimal GetBalance()
        {
            return Balance;
        }
    }
}

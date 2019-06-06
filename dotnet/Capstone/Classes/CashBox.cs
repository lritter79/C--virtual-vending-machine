using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class CashBox
    {
        public decimal CustomerBalance { get; set; }
        public decimal MachineBalance { get; set; }

        public CashBox()
        {
            CustomerBalance = 0;
            MachineBalance = 0;
        }

        public void AddCustomerBalance(string feed)
        {
            decimal moneyFed = decimal.Parse(feed);
            if (moneyFed >= 0)
            {
                CustomerBalance += moneyFed;
            }
        }

        public decimal GetBalance()
        {
            return CustomerBalance;
        }
    }
}

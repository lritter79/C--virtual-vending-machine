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
        /// <summary>
        /// Amount of money the customer puts in
        /// </summary>
        public decimal CustomerBalance { get; set; }
        
        /// <summary>
        /// The amount of money currently in the machine 
        /// </summary>
        public decimal MachineBalance { get; set; }

        /// <summary>
        /// Handles all financial transactions in the vending machine
        /// </summary>
        public CashBox()
        {
            CustomerBalance = 0;
            MachineBalance = 0;
        }

        /// <summary>
        /// Adds the amount input by the user to the balance
        /// </summary>
        /// <param name="feed"></param>
        public void AddCustomerBalance(string feed)
        {
            try
            {
                decimal moneyFed = decimal.Parse(feed);
                if (moneyFed >= 0)
                {
                    CustomerBalance += moneyFed;
                }
            }
            catch (Exception)
            {
               Console.WriteLine("Error: Please enter a whole number");
            }

        }

        public decimal GetBalance()
        {
            return CustomerBalance;
        }
        public void AddMachineBalance(decimal sale)
        {
            MachineBalance += sale;
        }

        public void SoldOut()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("That Item is Sold Out!");
            Console.WriteLine("----------------------");
        }
        public void OutOfFunds()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("You don't have enough money!");
            Console.WriteLine("----------------------");
        }

        //needs a method to subtract mone when an item is sold?
    }
}

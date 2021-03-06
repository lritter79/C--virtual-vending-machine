﻿using System;
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
                if (moneyFed >= 0 && ((moneyFed % 1) == 0))
                { 
                    CustomerBalance += moneyFed;
                    Console.WriteLine("You have fed " + moneyFed.ToString("C2"));
                    Console.WriteLine("Your balance is now " + CustomerBalance.ToString("C2"));
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Error: Please enter a whole number");
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

        public void DisplayOptions()
        {
            Console.WriteLine("(1) Feed Money");
            Console.WriteLine("(2) Select Product");
            Console.WriteLine("(3) Finish Transaction");
        }

        public void SoldOut()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("That Item is Sold Out!");
            Console.WriteLine("---------------------------");
        }
        public void OutOfFunds()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("You don't have enough money!");
            Console.WriteLine("---------------------------");
        }

       
    }
}

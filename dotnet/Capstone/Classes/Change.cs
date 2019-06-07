using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public static class Change
    {
        public static string GetChangeString(decimal remainingbalance)
        {
            int cents = (int)(remainingbalance * 100M);
            int nickelAmount = 0;
            int dimeAmount = 0;
            int quarterAmount = 0;

            while(cents - 25 >= 0)
            {
                cents -= 25;
                quarterAmount++;
            }
            while(cents - 10 >= 0)
            {
                cents -= 10;
                dimeAmount++;
            }
            while (cents - 5 >= 0)
            {
                cents -= 5;
                quarterAmount++;
            }
            return "Please take your " +
                remainingbalance.ToString("C2") +
                " in coins:\n" +
                quarterAmount +
                " Quarters, " +
                dimeAmount +
                " Dimes, and " +
                nickelAmount +
                " Nickels.";
        }
    }
}

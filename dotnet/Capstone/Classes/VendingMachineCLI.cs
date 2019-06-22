using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class VendingMachineCLI
    {
        public static string GetString()
        {
            string userInput = String.Empty;
            int numberOfAttempts = 0;

            do
            {
                if (numberOfAttempts > 0)
                {
                    Console.WriteLine("Invalid input format. Please try again");
                }

                
                userInput = Console.ReadLine();
                numberOfAttempts++;
            }
            while (String.IsNullOrEmpty(userInput));

            return userInput;
        }

        public static void InputIsTwoMainMenu()
        {
            
            Console.WriteLine("Please enter a valid number from the menu to continue");
            Console.WriteLine("-----------------------------------------------------");
        }

    }
}

using System;
using Capstone.Classes;


namespace Capstone
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = "";
            bool falseInput = false;
            do
            {
                Console.WriteLine("(1) Display Vending Machine Items");
                Console.WriteLine("(2) Purchase");
                input = Console.ReadLine();

                falseInput = input != "1" && input != "2";
                if (falseInput)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Please Enter 1 or 2.");
                }

            } while (falseInput);
            if (input == "1")
            {
                Menu.DisplayMenu();
            }
            Console.ReadLine();

            
            //Chips chips = new Chips("a1", "chips", 0M, "chips");
            //Console.WriteLine(chips.Phrase);
            //Menu.ReadFile();
            //Console.ReadLine();

        }
    }
}

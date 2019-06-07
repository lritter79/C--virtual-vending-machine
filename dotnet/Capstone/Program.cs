using System;
using Capstone.Classes;


namespace Capstone
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CashBox cashBox = new CashBox();
            Inventory inventory = new Inventory();
            decimal balance = cashBox.GetBalance();
            string input = "";

            Console.WriteLine("(1) Display Vending Machine Items");
            Console.WriteLine("(2) Purchase");
            input = Console.ReadLine();


            if (input == "1")
            {
                Menu.DisplayMenu(balance, inventory);
            }
            if (input == "2")
            {
            while(input != "3")
                {
                    Console.WriteLine();
                    Console.WriteLine("(1) Feed Money");
                    Console.WriteLine("(2) Select Product");
                    Console.WriteLine("(3) Finish Transaction");

                    if (input == "1")
                    {
                        Console.WriteLine("Please enter a full dollar amount");
                        cashBox.AddCustomerBalance(Console.ReadLine());
                    }
                    if (input == "2")
                    {
                        Console.WriteLine("Enter a product code");
                        {
                            string code = Console.ReadLine();
                            decimal price = inventory.GetPrice(code);
                            string priceStr = price.ToString("C2");
                            string product = inventory.GetProductName(code);
                            string phrase = inventory.GetPhrase(code);
                            int count = inventory.GetCount(code);
                            if(count < 1)
                            {
                                Console.WriteLine("That Item is Sold Out!");
                            }
                        }
                    }
                }
            

            }

                Console.ReadLine();

            
            //Chips chips = new Chips("a1", "chips", 0M, "chips");
            //Console.WriteLine(chips.Phrase);
            //Menu.ReadFile();
            //Console.ReadLine();

        }
    }
}

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
            bool displayMenu = false;
            int count = 5;
            decimal sale = 0M;

            Console.WriteLine("(1) Display Vending Machine Items");
            Console.WriteLine("(2) Purchase");
            input = Console.ReadLine();


            while (input == "1")
            {
                Menu.DisplayMenu(balance, inventory);
                input = Console.ReadLine();
            }
            if (input == "2")
            {
                while (input != "3")
                {
                    if (displayMenu)
                    {
                        Menu.DisplayMenu(balance, inventory);
                    }
                    if (count < 1)
                    {
                        Console.WriteLine("----------------------");
                        Console.WriteLine("That Item is Sold Out!");
                        Console.WriteLine("----------------------");
                    }
                    Console.WriteLine();
                    Console.WriteLine("(1) Feed Money");
                    Console.WriteLine("(2) Select Product");
                    Console.WriteLine("(3) Finish Transaction");
                    Console.WriteLine("Current Money Provided: " + balance.ToString("C2"));

                    input = Console.ReadLine();

                    if (input == "1")
                    {
                        Console.WriteLine("Please enter a full dollar amount");
                        cashBox.AddCustomerBalance(Console.ReadLine());
                        balance = cashBox.GetBalance();
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

                            if (balance <   price)
                            {
                                Console.WriteLine("----------------------");
                                Console.WriteLine("You don't have enough money!");
                                Console.WriteLine("----------------------");
                            }
                            else if (count < 1)
                            {
                                Console.WriteLine("----------------------");
                                Console.WriteLine("That Item is Sold Out!");
                                Console.WriteLine("----------------------");
                            }
                            else
                            {
                                
                                count = inventory.GetCount(code);
                                balance -= price;
                                sale = inventory.NewSale(code);
                                cashBox.AddMachineBalance(sale);
                                displayMenu = true;
                                Console.WriteLine();
                                Console.WriteLine(phrase);
                                Console.WriteLine("------");
                                Console.WriteLine("Press enter to continue");
                                input = Console.ReadLine();
                            }
                        }
                    }
                }
                decimal change = balance;
                Console.WriteLine(Change.GetChangeString(change));



            }
            

        Console.ReadLine();

            
            //Chips chips = new Chips("a1", "chips", 0M, "chips");
            //Console.WriteLine(chips.Phrase);
            //Menu.ReadFile();
            //Console.ReadLine();

        }
    }
}

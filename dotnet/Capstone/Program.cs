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
            decimal oldBalance = 0M;
            string input = "";
            int count = 5;
            decimal sale = 0M;
            string logString = "";
            bool finished = false;
            while(!finished)
            {
                Console.WriteLine("(1) Display Vending Machine Items");
                Console.WriteLine("(2) Purchase");
                Console.WriteLine("(3) Exit");
                input = Console.ReadLine();

                if (input == "1")
                {
                    Menu.DisplayMenu(balance, inventory);
                    input = Console.ReadLine();
                }
                if (input == "2")
                {
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
                        oldBalance = balance;
                        balance = cashBox.GetBalance();
                        logString = "FEED MONEY: ";
                        Log.WriteLog(logString, oldBalance, balance);
                    }
                    if (input == "2")
                    {

                        Console.WriteLine("Enter a product code");

                        string code = Console.ReadLine();
                        decimal price = inventory.GetPrice(code);
                        string priceStr = price.ToString("C2");
                        string product = inventory.GetProductName(code);
                        string phrase = inventory.GetPhrase(code);

                        if (balance < price)
                        {
                            cashBox.OutOfFunds();
                        }
                        else if (count < 1)
                        {
                            cashBox.SoldOut();
                        }
                        else
                        {
                            logString = product + " " + code + " ";
                            count = inventory.GetCount(code);
                            oldBalance = balance;
                            balance -= price;
                            sale = inventory.NewSale(code);
                            cashBox.AddMachineBalance(sale);
                            Log.WriteLog(logString, oldBalance, balance);
                            Console.WriteLine();
                            Console.WriteLine(phrase);
                            Console.WriteLine("Remaining Balance: " + balance);
                            Console.WriteLine("------");
                            Console.WriteLine("Press enter to continue");
                            input = Console.ReadLine();
                        }
                    }
                    if (input == "3")
                    {
                        decimal change = balance;
                        Console.WriteLine(Change.GetChangeString(change));
                        Console.WriteLine();
                        oldBalance = balance;
                        balance = 0M;
                        logString = "GIVE CHANGE: ";
                        Log.WriteLog(logString, oldBalance, balance);
                    }
                }
                if (input == "3")
                {
                    finished = true;
                    Console.WriteLine();
                    Console.WriteLine("Goodbye!");
                    Console.ReadLine();
                }
                if (input == "4")
                {
                    Log.WriteSalesReport(SalesReport.GetSales(inventory), cashBox.MachineBalance);
                }
            }
            

            
            //Chips chips = new Chips("a1", "chips", 0M, "chips");
            //Console.WriteLine(chips.Phrase);
            //Menu.ReadFile();
            //Console.ReadLine();

        }
    }
}

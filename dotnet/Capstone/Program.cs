using System;
using Capstone.Classes;


namespace Capstone
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Here are our global variables
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
                Menu.PrintUserOptions();
                input = Console.ReadLine();
                Console.WriteLine();

                if (input == "1")
                {
                    Menu.DisplayMenu(balance, inventory);
                    Console.WriteLine();
                    

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

                    if (input == "4")
                    {
                        Console.WriteLine("Please enter a valid number to continue");
                        Log.WriteSalesReport(SalesReport.GetSales(inventory), cashBox.MachineBalance);
                    }



                }
                if (input == "3")
                {
                    finished = true;
                    Console.WriteLine();
                    Console.WriteLine("Goodbye!");
                    Console.ReadLine();
                }

                else if (input != "1" && input != "2" && input != "3")
                {
                    Console.WriteLine("Please enter a valid number to continue");
                    Console.WriteLine();
                }
            }   
        }
    }
}

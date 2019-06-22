using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class VendingMachine
    {
        // Here are our global variables
        CashBox cashBox = new CashBox();
        Inventory inventory = new Inventory();
        protected decimal balance { get; set; }
        decimal oldBalance = 0M;
        string input = "";
        int count = 5;
        decimal sale = 0M;
        string logString = "";
        bool finished = false;


        public void RunVendingMachine()
        {
            balance = cashBox.GetBalance();

            while (!finished)
            {
                Menu.PrintUserOptions();
                input = Console.ReadLine();
                Console.WriteLine();

                if (input == "1")
                {
                    Menu.DisplayMenu(balance, inventory);
                    Console.WriteLine("---------------------------------");


                }
                if (input == "2")
                {
                    Console.WriteLine("-----------------------------------------------------");
                    cashBox.DisplayOptions();

                    Console.WriteLine("Current Money Provided: " + balance.ToString("C2"));
                    Console.WriteLine("Please enter a valid number from the menu to continue");
                    Console.WriteLine("-----------------------------------------------------");

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

                        string code = Console.ReadLine().ToUpper();
                        //if 
                        try
                        {
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
                                Console.WriteLine("---------------------------");
                                Console.WriteLine(phrase);
                                Console.WriteLine("Remaining Balance: " + balance);
                                Console.WriteLine("------");
                                Console.WriteLine("Press enter to continue");
                                input = Console.ReadLine();
                            }
                        }
                        catch (Exception)
                        {
                            inventory.CodeNotInInventory();
                        }

                    }
                    if (input == "3")
                    {
                        decimal change = balance;
                        Console.WriteLine(Change.GetChangeString(change));

                        oldBalance = balance;
                        balance = 0M;
                        logString = "GIVE CHANGE: ";
                        Log.WriteLog(logString, oldBalance, balance);
                    }

                    if (input == "4")
                    {
                        Console.WriteLine();
                        Log.WriteSalesReport(SalesReport.GetSales(inventory), cashBox.MachineBalance);
                    }
                }

                if (input == "3")
                {
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Are you sure you want to exit? (Y)es or (N)o?");
                    Console.WriteLine("---------------------------------------------");
                    bool isSure = false;
                    while (!isSure)
                    {
                        string yOrNInput = Console.ReadLine().ToUpper();
                        if (yOrNInput == "Y")
                        {

                            finished = true;
                            Console.WriteLine();
                            Console.WriteLine("Goodbye!");
                            Console.ReadLine();
                            isSure = true;
                        }

                        else if (yOrNInput == "N")
                        {
                            isSure = true;
                        }

                        else
                        {

                            Console.WriteLine("Please Enter Y or N");
                        }
                    }

                    Console.WriteLine("--------------------------------------");
                }

                else if (input != "1" && input != "2" && input != "3")
                {
                    Console.WriteLine("Please enter a valid number from the menu to continue");
                    Console.WriteLine("-----------------------------------------------------");
                }
            }
        }
    }
}

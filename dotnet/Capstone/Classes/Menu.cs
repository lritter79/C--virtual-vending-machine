using Capstone.Classes;
﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public static class Menu
    {
        public static void DisplayMenu(decimal balance)
        {
            // Directory and file name
            string directory = Environment.CurrentDirectory;
            string filename = "vendingmachine.csv";

            // Full Path
            string fullPath = Path.Combine(directory, "..\\..\\..\\..\\etc", filename);

            // Here we'll read in the file, separate each word with a comma and store
            // the individual word in a collection.
            List<string> allWords = new List<string>();
            string currentMoney = balance.ToString("C2");
            Dictionary<string, dynamic> stock = new Dictionary<string, dynamic>();
            Stock.StockVendingMachine(stock);

            foreach (KeyValuePair<string, dynamic> kvp in stock)
            {
                string snackType = kvp.Value.GetType().ToString();
                string[] arr = snackType.Split('.');
                snackType = arr[arr.Length - 1];
                Item item = kvp.Value;
                Console.WriteLine(
                    item.SlotLocation.PadRight(4) +
                    "|" +
                    item.ProductName.PadRight(20) +
                    "|" +
                    item.Price.ToString("C2").PadRight(20)
                    );
            }

           
            Console.WriteLine();
            Console.WriteLine("Current Money Provided: " + currentMoney);
        }
    }
}
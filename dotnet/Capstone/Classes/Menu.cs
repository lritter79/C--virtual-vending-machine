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
        public static void PrintUserOptions()
        {
            Console.WriteLine("(1) Display Vending Machine Items");
            Console.WriteLine("(2) Purchase");
            Console.WriteLine("(3) Exit");
            Console.WriteLine();

        }
        public static void DisplayMenu(decimal balance, Inventory inventory)
        {
            string currentMoney = balance.ToString("C2");

            Dictionary <string, Item> currentInventory = inventory.InventoryDictionary;
            foreach (KeyValuePair<string, Item> kvp in currentInventory)
            {
                string snackType = kvp.Value.GetType().ToString();
                string[] arr = snackType.Split('.');
                snackType = arr[arr.Length - 1];
                Item item = kvp.Value;
                string souldOut = "";
                if (kvp.Value.ItemCount() < 1)
                {
                    souldOut = " (SOLD OUT)";
                }

                string price = item.Price.ToString("C2") + souldOut;
                Console.WriteLine(
                    item.SlotLocation.PadRight(4) +
                    "|" +
                    item.ProductName.PadRight(20) +
                    "|" +
                    price
                    );
            }
            Console.WriteLine();
        }
    }
}
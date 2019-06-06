<<<<<<< HEAD
﻿using Capstone.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
=======
﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
>>>>>>> 3b80748c712bab42a4a3869eb5dc34bc9af0590c
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public static class Menu
    {

        public static void DisplayMenu()
        {
            // Directory and file name
            string directory = Environment.CurrentDirectory;
            string filename = "vendingmachine.csv";

            // Full Path
            string fullPath = Path.Combine(directory, "..\\..\\..\\..\\etc", filename);

            // Here we'll read in the file, separate each word with a comma and store
            // the individual word in a collection.
            List<string> allWords = new List<string>();
            decimal balance = 0;
            string currentMoney = balance.ToString("C2");
            Dictionary<string, dynamic> stock = new Dictionary<string, dynamic>();
            Stock.StockVendingMachine(stock);

            foreach (KeyValuePair<string, dynamic> kvp in stock)
            {
                Console.WriteLine("Type is " + kvp.Value.GetType());
            }

           
            Console.WriteLine();
            Console.WriteLine("Current Money Provided: " + currentMoney);
        }
    }
}
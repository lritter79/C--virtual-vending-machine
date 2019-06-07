using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public static class Stock
    {
        public static void StockVendingMachine(Dictionary<string, Item> stock)
        {
            // Directory and file name
            string directory = Environment.CurrentDirectory;
            string filename = "vendingmachine.csv";

            // Full Path
            string fullPath = Path.Combine(directory, "..\\..\\..\\..\\etc", filename);

            // Here we'll read in the file, separate each word with a comma and store
            // the individual word in a collection.
            try
            {

                using (StreamReader sr = new StreamReader(fullPath))
                {

                    while (!sr.EndOfStream)
                    {
                        int maxAmount = 5;
                        string line = sr.ReadLine();
                        string[] words = line.Split('|');
                        string snackType = words[3]; 
                        if (snackType == "Chip")
                        {
                            stock[words[0]] = new Chip(words[0], words[1], decimal.Parse(words[2]), words[3], maxAmount);
                        }
                        if (snackType == "Candy")
                        {
                            stock[words[0]] = new Candy(words[0], words[1], decimal.Parse(words[2]), words[3], maxAmount);
                        }
                        if (snackType == "Drink")
                        {
                            stock[words[0]] = new Drink(words[0], words[1], decimal.Parse(words[2]), words[3], maxAmount);
                        }
                        if (snackType == "Gum")
                        {
                            stock[words[0]] = new Gum(words[0], words[1], decimal.Parse(words[2]), words[3], maxAmount);
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error reading the file");
                Console.WriteLine(e.Message);
            }
        }
    }
}

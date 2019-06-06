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
        public static void StockVendingMachine(Dictionary<string, dynamic> stock)
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
                        string line = sr.ReadLine();
                        string[] words = line.Split('|');
                        string snackType = words[3]; 
                        if (snackType == "Chips")
                        {
                            stock[words[0]] = new Chips(words[1], words[2], decimal.Parse(words[3]), "Chips");
                        }
                        if (snackType == "Candy")
                        {
                            stock[words[0]] = new Chips(words[1], words[2], decimal.Parse(words[3]), "Candy");
                        }
                        if (snackType == "Drink")
                        {
                            stock[words[0]] = new Chips(words[1], words[2], decimal.Parse(words[3]), "Drink");
                        }
                        if (snackType == "Gum")
                        {
                            stock[words[0]] = new Chips(words[1], words[2], decimal.Parse(words[3]), "Gum");
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

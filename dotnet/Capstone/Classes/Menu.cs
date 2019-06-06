using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public static class Menu
    {

        public static void ReadFile()
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
            try
            {

                using (StreamReader sr = new StreamReader(fullPath))
                {

                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] words = line.Split(',');
                        allWords.AddRange(words);

                    } 
                }
            }
            catch (IOException e) 
            {
                Console.WriteLine("Error reading the file");
                Console.WriteLine(e.Message);
            }
            foreach (string word in allWords)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine();
            Console.WriteLine("Current Money Provided: " + currentMoney);
        }
    }
}
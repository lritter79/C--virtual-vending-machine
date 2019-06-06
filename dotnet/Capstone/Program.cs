using System;
using Capstone.Classes;


namespace Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            Chips chips = new Chips("a1", "chips", 0M, "chips");
            Console.WriteLine(chips.Phrase);
            Console.ReadLine();
        }
    }
}

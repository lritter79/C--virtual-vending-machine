using Capstone.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class Inventory
    {
        public Dictionary<string, Item> InventoryDictionary { get; }

        public Inventory()
        {
            InventoryDictionary = new Dictionary<string, Item>();
            Stock.StockVendingMachine(InventoryDictionary);
        }
        public decimal GetPrice(string code)
        {
            decimal price = InventoryDictionary[code].Price;
            return price;
        }
        public string GetProductName(string code)
        {
            string productName = InventoryDictionary[code].ProductName;
            return productName;
        }
        public string GetPhrase(string code)
        {
            string phrase = InventoryDictionary[code].SayPhrase();
            return phrase;
        }

        public int GetCount(string code)
        {
            int count = InventoryDictionary[code].ItemCount();
            return count;
        }
        public decimal NewSale(string code)
        {
            decimal sale = InventoryDictionary[code].Sale();
            return sale;
        }
    }
}

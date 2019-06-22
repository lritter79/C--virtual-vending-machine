using Capstone.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public static class SalesReport
    {
        public static Dictionary<string, int> SalesLog { get; set; }

        public static Dictionary<string, int> GetSales(Inventory inventory)
        {
            SalesLog = new Dictionary<string, int>();
            foreach (KeyValuePair<string, Item> kvp in inventory.InventoryDictionary)
            {
                SalesLog[kvp.Value.ProductName] = 5 - kvp.Value.Count;
            }
            return SalesLog;
        }
    }
}

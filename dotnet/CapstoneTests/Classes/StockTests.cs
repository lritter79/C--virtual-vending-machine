using CapstoneTests.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Classes;

namespace CapstoneTests.Classes
{
    [TestClass]
    public class StockTests
    {
        [TestMethod]
        public void IsStockWorking()
        {
            Inventory inventory = new Inventory();
            Dictionary<string, Item> testDict = new Dictionary<string, Item>();
            Stock.StockVendingMachine(testDict);
            foreach (KeyValuePair<string, Item> kvp in testDict)
            {
                Assert.AreEqual(kvp.Key, kvp.Value.SlotLocation);
            }
        }


    }
}

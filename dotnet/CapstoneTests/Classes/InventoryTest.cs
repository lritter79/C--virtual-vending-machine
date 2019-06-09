using CapstoneTests.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Classes;

namespace CapstoneTests.Classes
{
    [TestClass]
    public class InventoryTest
    {
        [TestMethod]
        public void InventoryPriceTests()
        {
            // Arrange
            Inventory test = new Inventory();
            
            // Act

            // Assert
            foreach (KeyValuePair<string, Item> kvp in test.InventoryDictionary)
            {
                Assert.AreEqual(test.GetPrice(kvp.Key),kvp.Value.Price);
            }
        }

        [TestMethod]
        public void InventoryCountTests()
        {
            // Arrange
            Inventory test = new Inventory();

            // Act

            // Assert
            foreach (KeyValuePair<string, Item> kvp in test.InventoryDictionary)
            {
                Assert.AreEqual(test.GetCount(kvp.Key), kvp.Value.ItemCount());
            }
        }

        [TestMethod]
        public void InventoryPhraseTests()
        {
            // Arrange
            Inventory test = new Inventory();

            // Act

            // Assert
            foreach (KeyValuePair<string, Item> kvp in test.InventoryDictionary)
            {
                Assert.AreEqual(test.GetPhrase(kvp.Key), kvp.Value.SayPhrase());
            }
        }

        [TestMethod]
        public void InventoryProductNameTests()
        {
            // Arrange
            Inventory test = new Inventory();

            // Act

            // Assert
            foreach (KeyValuePair<string, Item> kvp in test.InventoryDictionary)
            {
                Assert.AreEqual(test.GetProductName(kvp.Key), kvp.Value.ProductName);
            }
        }

        [TestMethod]
        public void InventorySaleTest()
        {
            // Arrange
            Inventory test = new Inventory();

            // Act

            // Assert
            foreach (KeyValuePair<string, Item> kvp in test.InventoryDictionary)
            {
                Assert.AreEqual(test.NewSale(kvp.Key), kvp.Value.Sale());
            }
        }
    }
}

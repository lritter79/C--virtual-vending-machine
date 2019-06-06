using CapstoneTests.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Classes;

namespace CapstoneTests.Classes
{
    [TestClass]
    public class DrinkTests

    {
        [TestMethod]
        public void HasProperties()
        {
            // Arrange
            Drink testDrink = new Drink("x", "y", 6.01M, "drink", 5);

            // Act

            string DrinkPhrase = testDrink.SayPhrase();

            // Assert
            Assert.AreEqual(testDrink.SlotLocation, "x");
         
            Assert.AreEqual(testDrink.ProductName, "y");
            Assert.AreEqual(testDrink.Price, 6.01M);
            Assert.AreEqual(testDrink.Type, "drink");
            Assert.AreEqual(DrinkPhrase, "Glug Glug, Yum!");

        }
    }
}

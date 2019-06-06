using CapstoneTests.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Classes;

namespace CapstoneTests.Classes
{
    [TestClass]
    class DrinkTests

    {
        [TestMethod]
        public void HasProperties()
        {
            // Arrange
            Drink testGum = new Drink("x", "y", 6.01M, "drink");

            // Act


            // Assert
            Assert.AreEqual(testGum.SlotLocation, "x");
            Assert.AreEqual(testGum.ProductName, "y");
            Assert.AreEqual(testGum.Price, 6.01M);
            Assert.AreEqual(testGum.Type, "drink");

        }
    }
}

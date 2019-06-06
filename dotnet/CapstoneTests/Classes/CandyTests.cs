using CapstoneTests.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Classes;

namespace CapstoneTests.Classes
{
    [TestClass]
    public class CandyTests

    {
        [TestMethod]
        public void HasProperties()
        {
            // Arrange
            Candy testcandy = new Candy("x", "y", 6.01M, "candy");

            // Act

            string phrase = testcandy.SayPhrase();

            // Assert
            Assert.AreEqual(testcandy.SlotLocation, "x");

            Assert.AreEqual(testcandy.ProductName, "y");
            Assert.AreEqual(testcandy.Price, 6.01M);
            Assert.AreEqual(testcandy.Type, "candy");
            Assert.AreEqual(phrase, "Munch Munch, Yum!");

        }
    }
}

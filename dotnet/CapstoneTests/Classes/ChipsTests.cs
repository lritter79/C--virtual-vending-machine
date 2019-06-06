using CapstoneTests.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Classes;

namespace CapstoneTests.Classes
{
    [TestClass]
    public class ChipsTests

    {
        [TestMethod]
        public void HasProperties()
        {
            // Arrange
            Chip testChips = new Chip("x", "y", 6.01M, "chips", 5);

            // Act

            string phrase = testChips.SayPhrase();

            // Assert
            Assert.AreEqual(testChips.SlotLocation, "x");

            Assert.AreEqual(testChips.ProductName, "y");
            Assert.AreEqual(testChips.Price, 6.01M);
            Assert.AreEqual(testChips.Type, "chips");
            Assert.AreEqual(5, testChips.Count);


            Assert.AreEqual(phrase, "Crunch Crunch, Yum!");

        }
    }
}

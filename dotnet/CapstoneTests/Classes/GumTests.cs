using CapstoneTests.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Classes;



namespace CapstoneTests.Classes
{
    [TestClass]
    public class GumTests
    {
        [TestMethod]
        public void HasProperties()
        {
            // Arrange
            Gum testGum = new Gum("x", "y", 6.01M, "gum");

            // Act

            string gumPhrase = testGum.SayPhrase();

            // Assert
            Assert.AreEqual(testGum.SlotLocation, "x");
            Assert.AreEqual(testGum.ProductName, "y");
            Assert.AreEqual(testGum.Price, 6.01M);
            Assert.AreEqual(testGum.Type, "gum");
            Assert.AreEqual("Chew Chew, Yum!", gumPhrase);


        }

    }
}

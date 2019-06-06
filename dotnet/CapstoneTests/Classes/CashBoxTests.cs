using CapstoneTests.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Classes;

namespace CapstoneTests.Classes
{
    [TestClass]
    public class CashBoxTests

    {
        [TestMethod]
        public void Properties()
        {
            // Arrange
            CashBox test = new CashBox();

            // Act


            // Assert
            Assert.AreEqual(test.Balance, 0);
           

        }

        [TestMethod]
        public void DoesAddBalanceWork()
        {
            // Arrange
            CashBox test = new CashBox();

            // Act
            test.AddBalance("1");

            // Assert
            Assert.AreEqual(test.Balance, 1);
        }

        [TestMethod]
        public void NotAddingNegativeBalance()
        {
            // Arrange
            CashBox test = new CashBox();

            // Act
            test.AddBalance("-1");

            // Assert
            Assert.AreEqual(test.Balance, 0);
        }

        [TestMethod]
        public void NotAddingString()
        {
            // Arrange
            CashBox test = new CashBox();

            // Act
            test.AddBalance("a");

            // Assert
            Assert.AreEqual(0, test.Balance);
        }

        [TestMethod]
        public void NotAddingNull()
        {
            // Arrange
            CashBox test = new CashBox();

            // Act
            test.AddBalance("");

            // Assert
            Assert.AreEqual(0, test.Balance);
        }


        [TestMethod]
        public void NotAddingNonInteger()
        {
            // Arrange
            CashBox test = new CashBox();

            // Act
            test.AddBalance("1.5");

            // Assert
            Assert.AreEqual(0, test.Balance);
        }

    }
}

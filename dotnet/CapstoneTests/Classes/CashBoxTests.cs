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
            Assert.AreEqual(0, test.CustomerBalance);
           

        }

        [TestMethod]
        public void DoesAddBalanceWork()
        {
            // Arrange
            CashBox test = new CashBox();

            // Act
            test.AddCustomerBalance("1");

            // Assert
            Assert.AreEqual(test.CustomerBalance, 1);
        }

        [TestMethod]
        public void NotAddingNegativeBalance()
        {
            // Arrange
            CashBox test = new CashBox();

            // Act
            test.AddCustomerBalance("-1");

            // Assert
            Assert.AreEqual(test.CustomerBalance, 0);
        }

        [TestMethod]
        public void NotAddingString()
        {
            // Arrange
            CashBox test = new CashBox();

            // Act
            test.AddCustomerBalance("a");

            // Assert
            Assert.AreEqual(0, test.CustomerBalance);
        }

        [TestMethod]
        public void NotAddingNull()
        {
            // Arrange
            CashBox test = new CashBox();

            // Act
            test.AddCustomerBalance("");

            // Assert
            Assert.AreEqual(0, test.CustomerBalance);
        }


        [TestMethod]
        public void NotAddingNonInteger()
        {
            // Arrange
            CashBox test = new CashBox();

            // Act
            test.AddCustomerBalance("1.5");

            // Assert
            Assert.AreEqual(0, test.CustomerBalance);
        }

    }
}

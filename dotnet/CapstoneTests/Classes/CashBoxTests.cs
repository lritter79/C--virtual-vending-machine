using CapstoneTests.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Classes;

namespace CapstoneTests.Classes
{
    [TestClass]
    class CasTests

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
    }
}

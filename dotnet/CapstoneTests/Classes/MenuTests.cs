using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CapstoneTests.Classes
{
    [TestClass]
    public class MenuTests
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
        }
}

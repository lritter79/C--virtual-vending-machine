using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Classes;

namespace CapstoneTests.Classes
{
    [TestClass]
    public class MenuTests
    {


            [TestMethod]
            public void Properties()
            {
            // Arrange

            Inventory test = new Inventory();
            // Act
            Menu.DisplayMenu(0, test);
            
              // Assert
          

            }
    }
}

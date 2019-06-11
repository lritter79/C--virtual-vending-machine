using CapstoneTests.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Classes;
using System.IO;
using System.Linq;

namespace CapstoneTests.Classes
{
    [TestClass]
    public class SalesReportTest
    {
        [TestMethod]
        public void DictionaryTest()
        {
            // Directory and file name
            string directory = Environment.CurrentDirectory;
            string filename = "vendingmachine.csv";

            // Full Path
            string fullPath = Path.Combine(directory, "..\\..\\..\\..\\etc", filename);
            var file = new StreamReader(fullPath).ReadToEnd(); // big string
            Array lines = file.Split(new char[] { '\n' });           // big array
            int count = lines.Length;

            Inventory inventory = new Inventory();
            Dictionary<string, int>  testDict = SalesReport.GetSales(inventory);
            Assert.AreEqual(count, testDict.Count);

        }
    }
}

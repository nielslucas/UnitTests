using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    [TestFixture]
    class UnitTests
    {
        [TestCase]
        public void GenerateUniqueIntList_UniqueInts_List()
        {
            // Create the instance of a Unique int list
            List<int> uniqueIntList = Program.GenerateUniqueIntList();
            // Now check if every int in unique, if so succes, if there are doubles it will fail
            Assert.IsTrue(uniqueIntList.Distinct().Count() == uniqueIntList.Count());
        }

        [TestCase]
        public void GenerateUniqueIntList_IntsMaxLenght5Digits_List()
        {
            // Create the instance of a Unique int list
            List<int> uniqueIntList = Program.GenerateUniqueIntList();

            // Check foreach int if its max value is 99999 (because max 5 digits)
            foreach (int integer in uniqueIntList)
            {
                Assert.That(integer, Is.AtMost(99999), "Number is greater than max number length of 5");
            }
        }

        [TestCase]
        public void CheckOutpuFileLocation()
        {
            string root = Directory.GetCurrentDirectory();
            string fileName = "/output.txt";

            Assert.IsTrue(File.Exists(root + fileName));
        }
    }
}

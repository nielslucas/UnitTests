using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    public class Tests
    {
        [TestFixture]
        class UnitTests
        {
            [TestCase]
            public void GenerateUniqueIntList_UniqueInts_List()
            {
                // Define program object instance
                Program program = new Program();
                // Create the instance of a Unique int list
                List<int> uniqueIntList = program.GenerateUniqueIntList();
                // Now check if every int in unique, if so succes, if there are doubles it will fail
                Assert.IsTrue(uniqueIntList.Distinct().Count() == uniqueIntList.Count());
            }

            [TestCase]
            public void GenerateUniqueIntList_IntsMaxLenght5Digits_List()
            {
                // Define program object instance
                Program program = new Program();
                // Create the instance of a Unique int list
                List<int> uniqueIntList = program.GenerateUniqueIntList();

                // Check foreach int if its max value is 99999 (because max 5 digits)
                foreach (int integer in uniqueIntList)
                {
                    Assert.That(integer, Is.AtMost(99999), "Number is greater than max number length of 5");
                }
            }

            [TestCase]
            public void CheckOutpuFileLocation()
            {
                // Define the root of the project .exe file
                string root = Directory.GetCurrentDirectory();

                // Define the root together with the file you are looking for
                string location = root + "/output.txt";

                // Check if that file exists
                File.Exists(location);

            }

            [Test]
            public void TestTerminalMock()
            {
                // String to out into the ConsoleLog
                string testLine = "Does this make sense?"; 

                // Define terminal object instance
                TerminalMock terminalMock = new TerminalMock();

                // Log the string
                terminalMock.ConsoleLog(testLine);

                // Check terminalMock.getLogMessage to original string
                // We just take the first record of the List because we are 100% sure we want the first record 
                Assert.That(terminalMock.getLogMessage().First(), Is.EqualTo(testLine));
            }
        }
    }
}

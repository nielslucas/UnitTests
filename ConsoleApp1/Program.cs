using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program : MyInterface
    {
        static void Main(string[] args)
        {
            // Define program object instance
            Program program = new Program();
            // Define program object instance
            program.CreateFileWithUniqueInts();
        }
        
        public void CreateFileWithUniqueInts()
        {
            // Generate a list of 100 int values that are converted to string
            List<string> randomNumbers = ConvertIntListToStringList(GenerateUniqueIntList());
            // Write the randNumbers to a file
            WriteToFile(randomNumbers);
        }

        // Generate List<int> with 100 unique ints
        public List<int> GenerateUniqueIntList()
        {
            // Create a list with integers
            List<int> randomNumbers = new List<int>();
            // Create a Random object
            Random random = new Random();
            // randomNumers should be 100 ints, so keep going toll you reach 100 values
            while (randomNumbers.Count() < 100)
            {
                // Define the the int of the  Random object, the int in between 0 and 100
                int randomNumber = random.Next(0, 101);

                // Check if the int exists in the randNumbers list, if not execute the code inside this if
                if (!randomNumbers.Contains(randomNumber))
                {
                    // Add the new randomNumber the the randomNumbers list
                    randomNumbers.Add(randomNumber);
                }

            }
            return randomNumbers;
        }

        public List<string> ConvertIntListToStringList(List<int> randomNumbers)
        {
            // Foreach value that exists in the List<int>randomNumbers convert into string so we get a List<string> back
            return randomNumbers.ConvertAll<string>(delegate (int i) { return i.ToString(); });
        }

        // Write a List<string> to a new file called 'output.txt' where the .exe file is located ("ConsoleApp1\bin\Debug")
        public void WriteToFile(List<string> randomNumbers)
        {
            // Foreach result in the List<string>randomNumers seperate it with a ',' and add it to a string.
            string result = String.Join(", ", randomNumbers);

            // Get the currect root the the project
            string root = Directory.GetCurrentDirectory();
            // Write the reulst to a textfile called 'output.txt' where the .exe file is located ("ConsoleApp1\bin\Debug")
            System.IO.File.WriteAllText(root + "/output.txt", result);

            // debugg write result also in console
            Console.WriteLine(result);
            Console.WriteLine(File.Exists(root + "/output.txt"));
            // Keep the console open
            Console.ReadLine();
        }
    }

}

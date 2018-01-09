using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> randomNumbers = new List<String>();
            Random random = new Random();
            while(randomNumbers.Count() < 100)
            {

                int randomNumber = random.Next(0, 101);

                if (!randomNumbers.Contains(randomNumber.ToString()))
                {
                    randomNumbers.Add(randomNumber.ToString());
                }
                
            }

            var result = String.Join(", ", randomNumbers.ToArray());

            System.IO.File.WriteAllText("output.txt", result);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

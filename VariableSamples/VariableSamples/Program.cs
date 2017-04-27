using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace VariableSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] source = { 12, 1, 5, -2, 16, 14 };
            int[] dest = { 1, 2, 3, 4 };

            Array.Copy(source, dest, 3);

            string message = "Hello World";

            if (message.Equals("hello world", StringComparison.OrdinalIgnoreCase))
                WriteLine("Strings are equal!");
            WriteLine($"{message} is {message.Length} characters.");

            List<int> userAgeList = new List<int> { 11, 21, 31, 41 };
            userAgeList.Add(51);
            userAgeList.Add(61);
            WriteLine($"There are {userAgeList.Count} ages in the list.");
            ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace HelloWorldAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "";
            int userAge = 0,
                currentYear = 0;

            Write("Please enter your name: ");
            userName = ReadLine();

            Write("Please enter your age: ");
            userAge = ToInt32(ReadLine());

            Write("Please enter the current year: ");
            currentYear = ToInt32(ReadLine());

            WriteLine("Hello World! My name is {0} and I am {1} years old.  I was born in {2}.",
                userName, userAge, currentYear - userAge);
            ReadKey();
        }
    }
}

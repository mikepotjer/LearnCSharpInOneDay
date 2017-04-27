using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace ConditionalSample1
{
    class Program
    {
        static void Main(string[] args)
        {
            int userAge;

            Write("Please enter your age: ");
            userAge = ToInt32(ReadLine());

            if (userAge < 0 || userAge > 100)
            {
                WriteLine("Invalid age");
                WriteLine("Age must be between 0 and 100");
            }
            else if (userAge < 18)
                WriteLine("Sorry, you are underage");
            else if (userAge < 21)
                WriteLine("You need parental consent");
            else
            {
                WriteLine("Congratulations!");
                WriteLine("You may sign up for the event!");
            }
            ReadKey();
        }
    }
}

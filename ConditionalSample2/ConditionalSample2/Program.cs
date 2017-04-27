using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConditionalSample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter your grade: ");
            string userGrade = ReadLine();

            switch (userGrade)
            {
                case "A+":
                case "A":
                    WriteLine("Distinction");
                    break;

                case "B":
                    WriteLine("B Grade");
                    break;

                case "C":
                    WriteLine("C Grade");
                    break;

                default:
                    WriteLine("Fail");
                    break;
            }
            ReadKey();
        }
    }
}

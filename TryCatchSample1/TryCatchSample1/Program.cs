using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace TryCatchSample1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            int[] numbers = { 10, 11, 12, 13, 14, 15 };
            Write("Please enter the index of the array: ");

            try
            {
                choice = ToInt32(ReadLine());
                WriteLine("numbers[{0}] = {1}", choice, numbers[choice]);
            }catch (IndexOutOfRangeException)
            {
                WriteLine("Error: Index should be from 0 to 5.");
            }catch (FormatException)
            {
                WriteLine("Error: You did not enter an integer.");
            }catch (Exception e)
            {
                WriteLine(e.Message);
            }
            ReadKey();
        }
    }
}

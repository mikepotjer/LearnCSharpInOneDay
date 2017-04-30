using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace ArrayListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5 };
            PrintFirstElement(myArray);

            List<int> myList = new List<int> { 1, 2, 3 };
            PrintFirstListElement(myList);

            int[] myArray2 = ReturnUserInput();

            List<int> myList2 = ReturnUserInputList();
            ReadKey();
        }

        //Note that without the "static" keyword, this would be an *instance* method,
        //and you can't call an instance method from a static method like Main() without
        //first instantiating an instance of the class.  So we would have to instantiate
        //an instance of Program in its Main() method, which is probably not a good idea.
        public static void PrintFirstElement(int[] a)
        {
            WriteLine("The first element is {0}.\n", a[0]);
        }

        public static void PrintFirstListElement(List<int> a)
        {
            WriteLine("The first list element is {0}.\n", a[0]);
        }

        public static int[] ReturnUserInput()
        {
            int[] a = new int[3];

            for (int i = 0; i < a.Length; i++)
            {
                Write("Enter an integer: ");
                a[i] = ToInt32(ReadLine());
                WriteLine("Integer added to array.\n");
            }

            return a;
        }

        public static List<int> ReturnUserInputList()
        {
            List<int> a = new List<int>();
            int input;

            for (int i = 0; i < 3; i++)
            {
                Write("Enter an integer: ");
                input = ToInt32(ReadLine());
                a.Add(input);
                WriteLine("Integer added to list.\n");
            }

            return a;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ParamsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNames("Carl");
            PrintNames("Mike", "Teresa");
            PrintNames("Annika", "Cassandra", "Zachary", "Naomi");
            ReadKey();
        }

        // params allows an indeterminate number of arguments, but it must
        // be the last parameter in the method declaration.
        public static void PrintNames(params string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Write(names[i] + " ");
            }
            WriteLine();
        }
    }
}

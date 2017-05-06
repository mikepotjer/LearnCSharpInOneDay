using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassA a = new ClassA();
            a.MyNumber = 5;
            a.InterfaceMethod();
            ReadKey();
        }
    }

    interface IShape
    {
        int MyNumber { get; set; }

        void InterfaceMethod();
    }

    class ClassA : IShape
    {
        private int myNumber;

        public int MyNumber
        {
            get
            {
                return myNumber;
            }

            set
            {
                if (value < 0)
                    myNumber = 0;
                else
                    myNumber = value;
            }
        }

        public void InterfaceMethod()
        {
            WriteLine("The number is {0}.", MyNumber);
        }
    }
}

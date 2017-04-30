using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ClassStaticDemo1
{
    class MyClass
    {
        //Non-static members
        public string message = "Hello World";
        public string Name { get; set; }
        public void DisplayName()
        {
            WriteLine("Name = {0}", Name);
        }

        //Static members
        public static string greetings = "Good morning";
        public static int Age { get; set; }
        public static void DisplayAge()
        {
            WriteLine("Age = {0}", Age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass classA = new MyClass();

            WriteLine(classA.message);
            classA.Name = "Mike";
            classA.DisplayName();

            WriteLine(MyClass.greetings);
            MyClass.Age = 51;
            MyClass.DisplayAge();
            ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6 };

            var evenNumQuery =
                from num in numbers
                where (num % 2) == 0
                select num;

            foreach (int i in evenNumQuery)
            {
                WriteLine("{0} is an even number", i);
            }

            List<Customer> customers = new List<Customer>();

            customers.Add(new Customer("Alan", "8091129", "ABC Street", 25.60m));
            customers.Add(new Customer("Bill", "1987213", "DEF Street", -32.1m));
            customers.Add(new Customer("Carl", "2981237", "GHI Street", -12.2m));
            customers.Add(new Customer("David", "7861231", "JKL Street", 12.6m));

            //The new keyword is needed whenever we want to select more than one field
            //from the objects.
            var overdue =
                from cust in customers
                where cust.Balance < 0
                orderby cust.Balance ascending
                select new { cust.Name, cust.Balance };

            foreach (var cust in overdue)
                WriteLine("Name = {0}, Balance = {1}", cust.Name, cust.Balance);

            ReadKey();
        }
    }

    class Customer
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public decimal Balance { get; set; }

        public Customer(string name, string phone, string address, decimal balance)
        {
            Name = name;
            Phone = phone;
            Address = address;
            Balance = balance;
        }
    }
}

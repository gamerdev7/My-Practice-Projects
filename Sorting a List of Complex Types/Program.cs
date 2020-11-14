using System;
using System.Collections.Generic;

namespace Sorting_using_IComparable_and_IComparer
{
    class Customer : IComparable<Customer> // Compares this instance to other instance.
    {
        public int id;
        public string name;
        public int salary;

        public int CompareTo(Customer other)
        {
            return this.id.CompareTo(other.id);
        }
    }

    class NameComparer : IComparer<Customer> // Compares 2 instances of the same type.
    {
        public int Compare(Customer x, Customer y)
        {
            return x.name.CompareTo(y.name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer() { id = 1, name = "Shubham", salary = 99000 };
            Customer c2 = new Customer() { id = 2, name = "Sam", salary = 88000 };
            Customer c3 = new Customer() { id = 3, name = "Shivam", salary = 90000 };
            Customer c4 = new Customer() { id = 4, name = "Shekhar", salary = 43000 };

            List<Customer> customers = new List<Customer>() { c2, c1, c3, c4 };

            Console.WriteLine("List Before Sorting");

            foreach (var customer in customers)
            {
                Console.WriteLine($"Id = {customer.id}, Name = {customer.name}, Salary = {customer.salary}");
            }

            customers.Sort();

            Console.WriteLine("\nList After Sorting based on ID");

            foreach (var customer in customers)
            {
                Console.WriteLine($"Id = {customer.id}, Name = {customer.name}, Salary = {customer.salary}");
            }

            customers.Sort(new NameComparer());

            Console.WriteLine("\nList After Sorting based on NAME");

            foreach (var customer in customers)
            {
                Console.WriteLine($"Id = {customer.id}, Name = {customer.name}, Salary = {customer.salary}");
            }

        }
    }
}

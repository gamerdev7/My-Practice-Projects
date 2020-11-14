using System;
using System.Collections.Generic;

namespace Sorting_using_Comparison_Delegate
{
    class Customer
    {
        public int id;
        public string name;
        public int salary;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer() { id = 1, name = "Shubham", salary = 99000 };
            Customer c2 = new Customer() { id = 2, name = "Sam", salary = 88000 };
            Customer c3 = new Customer() { id = 3, name = "Shivam", salary = 90000 };

            List<Customer> customers = new List<Customer>() { c2, c1, c3 };

            Console.WriteLine("List Before Sorting");

            foreach (var customer in customers)
            {
                Console.WriteLine($"Id = {customer.id}, Name = {customer.name}, Salary = {customer.salary}");
            }

            // Approach-1
            //Comparison<Customer> salaryComparer = CompareSalary; 
            //customers.Sort(salaryComparer);

            // Approach-2
            //customers.Sort(delegate (Customer c01, Customer c02)
            //                         {
            //                             return c01.salary.CompareTo(c02.salary);
            //                         }
            //               );

            // Approach-3
            customers.Sort((x, y) => x.salary.CompareTo(y.salary));

            Console.WriteLine("\nList After Sorting based on Salary");

            foreach (var customer in customers)
            {
                Console.WriteLine($"Id = {customer.id}, Name = {customer.name}, Salary = {customer.salary}");
            }
        }

        // Approach-1
        //public static int CompareSalary(Customer c1, Customer c2)
        //{
        //    return c1.salary.CompareTo(c2.salary);
        //}
    }
}

using System;
using System.Collections.Generic;

namespace List_Collection
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
            Customer c1 = new Customer() { id = 101, name = "Rob", salary = 4000 };
            Customer c2 = new Customer() { id = 102, name = "John", salary = 54000 };
            Customer c3 = new Customer() { id = 103, name = "Shubham", salary = 98000 };
            Customer c4 = new Customer() { id = 104, name = "Kunal", salary = 8000 };

            List<Customer> customerList = new List<Customer>(1);
            customerList.Add(c1);
            customerList.Add(c2);
            customerList.Add(c3);

            customerList.Insert(0, c4); // Insert at any index.

            foreach (Customer customer in customerList)
            {
                Console.WriteLine($"Id = {customer.id}, Name = {customer.name}, Salary = {customer.salary}");
            }

            Console.WriteLine();

            Console.WriteLine(customerList.Contains(c3)); // Checks if the list contains the object.

            Customer c = customerList.Find(cust => cust.salary > 8000); // Finds first element that matches the condition.
            Console.WriteLine($"Id = {c.id}, Name = {c.name}, Salary = {c.salary}");
        }
    }
}

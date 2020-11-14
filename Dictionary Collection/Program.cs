using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary_Collection
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

            Dictionary<int, Customer> customers = new Dictionary<int, Customer>();

            customers.Add(c1.id, c1);
            customers.Add(c2.id, c2);
            customers.Add(c3.id, c3);

            Customer value;
            if (customers.TryGetValue(103, out value))
            {
                Console.WriteLine("value");
                Console.WriteLine($"Id = {value.id}, Name = {value.name}, Salary = {value.salary}");
                Console.WriteLine("value\n");
            }

            Console.WriteLine($"Customer with id = 103 is {customers[103].name}"); // Fast lookup in customers using key = 103.

            Console.WriteLine("\nKey-Value Pairs");
            Console.WriteLine("-------------------------------------------------------------------------------------");
            foreach (KeyValuePair<int, Customer> customerKeyValue in customers)
            {
                Console.WriteLine($"Key = {customerKeyValue.Key}");
                Customer cust = customerKeyValue.Value;
                Console.WriteLine($"Id = {cust.id}, Name = {cust.name}, Salary = {cust.salary}");
                Console.WriteLine("-------------------------------------------------------------------------------------");
            }

            Console.WriteLine("\nOnly Keys");
            foreach (int key in customers.Keys) // Gets Collection of keys in the customers
            {
                Console.WriteLine($"Key = {key}");
            }

            Console.WriteLine("\nOnly Values");
            foreach (Customer customer in customers.Values) // Gets Collection of values in the customers
            {
                Console.WriteLine($"Id = {customer.id}, Name = {customer.name}, Salary = {customer.salary}");
            }
        }
    }


}

using System;
using System.Collections.Generic;

namespace Queue_Collection
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
            Customer c1 = new Customer() { id = 101, name = "John", salary = 54000 };
            Customer c2 = new Customer() { id = 102, name = "Shubham", salary = 98000 };
            Customer c3 = new Customer() { id = 103, name = "Shivam", salary = 8000 };

            Queue<Customer> customers = new Queue<Customer>();
            customers.Enqueue(c1);
            customers.Enqueue(c2);
            customers.Enqueue(c3);

            Customer cD = customers.Dequeue();
            Console.WriteLine($"Id = {cD.id}, Name = {cD.name}, Salary = {cD.salary}");
            Console.WriteLine($"Total items in Queue = {customers.Count}");

            Customer cP = customers.Peek();
            Console.WriteLine($"\nId = {cP.id}, Name = {cP.name}, Salary = {cP.salary}");
            Console.WriteLine($"Total items in Queue = {customers.Count}\n");

            if (customers.Contains(c1))
            {
                Console.WriteLine("c1 exists.");
            }
            else
            {
                Console.WriteLine("c1 doesn't exists.");
            }
        }
    }
}

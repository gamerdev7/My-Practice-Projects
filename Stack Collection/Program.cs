using System;
using System.Collections.Generic;

namespace Stack_Collection
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

            Stack<Customer> customers = new Stack<Customer>();
            customers.Push(c1);
            customers.Push(c2);
            customers.Push(c3);

            Customer cPop = customers.Pop();
            Console.WriteLine($"Id = {cPop.id}, Name = {cPop.name}, Salary = {cPop.salary}");
            Console.WriteLine($"Total items in Stack = {customers.Count}\n");

            Customer cPeek = customers.Peek();
            Console.WriteLine($"Id = {cPeek.id}, Name = {cPeek.name}, Salary = {cPeek.salary}");
            Console.WriteLine($"Total items in Stack = {customers.Count}\n");

            Console.WriteLine("Foreach Loop executing..."); //foreach retrieves items in LIFO order.
            foreach (var customer in customers)
            {
                Console.WriteLine($"Id = {customer.id}, Name = {customer.name}, Salary = {customer.salary}");
            }
        }
    }
}

using System;

namespace Classes
{
    class Customer
    {
        string firstName;
        string lastName;

        public Customer(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Customer()
            : this("No FirstName Provided", "No LastName Provided")
        {
        }

        public void PrintFullName()
        {
            Console.WriteLine($"Full Name : {firstName + " " + lastName}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("Shubham", "Sati");
            c1.PrintFullName();

            Customer c2 = new Customer();
            c2.PrintFullName();

        }
    }
}

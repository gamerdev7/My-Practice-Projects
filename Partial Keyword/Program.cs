using System;

namespace Partial_Classes
{
    public class Customer 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer { FirstName = "Rob", LastName = "Miles" };
            Console.WriteLine(c.GetFullName());

            PartialCustomer c2 = new PartialCustomer { FirstName = "John", LastName = "Miles" };
            Console.WriteLine(c2.GetFullName());
        }
    }
}

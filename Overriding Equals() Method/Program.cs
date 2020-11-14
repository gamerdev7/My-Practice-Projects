using System;

namespace Overriding_Equals___Method
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Customer))
            {
                return false;
            }

            return (this.FirstName == ((Customer)obj).FirstName) && (this.LastName == ((Customer)obj).LastName);
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { FirstName = "Jon", LastName = "Skeet" };
            Customer customer2 = new Customer { FirstName = "Rob", LastName = "Miles" };
            Customer customer3 = new Customer { FirstName = "Rob", LastName = "Miles" };

            Console.WriteLine(customer1 == customer2); // Checking Reference Equality.
            Console.WriteLine(customer1.Equals(customer2)); // Checking Value Equality due to overriding.

            Console.WriteLine(customer2 == customer3); // Checking Reference Equality.
            Console.WriteLine(customer2.Equals(customer3)); // Checking Value Equality due to overriding.
        }
    }
}

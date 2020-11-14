using System;

namespace Structure
{
    public struct Customer
    {
        private int _id; // Field.
        public string Name { get; set; } // Auto-Implemented property.

        public int Id // Property.
        {
            get { return this._id; }
            set { this._id = value; }
        }

        public Customer(int id, string name) // Constructor.
        {
            _id = 0;
            this.Name = name;
            this.Id = id; 

        }

        public void DisplayDetails() // Method.
        {
            Console.WriteLine($"Id : {this.Id} Name : {this.Name}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer(1, "Rob");
            c1.DisplayDetails();
        }
    }
}
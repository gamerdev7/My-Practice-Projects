using System;

namespace Inheritance
{
    class Employee
    {
        public string firstName;
        public string lastName;

        public Employee()
        {
            Console.WriteLine("Employee Constructor called.");
        }

        public void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

    class FullTimeEmployee : Employee
    {
        public int yearlySalary;

        public FullTimeEmployee()
        {
            Console.WriteLine("FullTimeEmployee Constructor called.");
        }
    }

    class PartTimeEmployee : Employee
    {
        public int hourlyRate;

        public PartTimeEmployee()
        {
            Console.WriteLine("PartTimeEmployee Constructor called.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fte = new FullTimeEmployee
            {
                firstName = "Rob",
                lastName = "Miles",
                yearlySalary = 400000
            };

            fte.PrintFullName();

            PartTimeEmployee pte = new PartTimeEmployee
            {
                firstName = "Shubham",
                lastName = "Sati",
                hourlyRate = 5000
            };

            pte.PrintFullName();
        }
    }
}

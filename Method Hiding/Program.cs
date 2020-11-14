using System;

namespace Method_Hiding
{
    class Employee
    {
        public string firstName;
        public string lastName;

        public void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

    class PartTimeEmployee : Employee
    {
        public new void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName + " - PartTimeEmployee");
        }
    }

    class FullTimeEmployee : Employee
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fte = new FullTimeEmployee
            {
                firstName = "Rob",
                lastName = "Miles"
            };
            fte.PrintFullName();

            PartTimeEmployee pte = new PartTimeEmployee
            {
                firstName = "Shubham",
                lastName = "Sati"
            };
            pte.PrintFullName();

            Employee employee = new PartTimeEmployee
            {
                firstName = "Jon",
                lastName = "Skeet"
            };
            employee.PrintFullName();
        }
    }
}


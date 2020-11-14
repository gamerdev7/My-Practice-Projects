using System;

namespace Method_Overriding
{
    class Employee
    {
        public string firstName;
        public string lastName;

        public virtual void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

    class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName + " - PartTimeEmployee");
        }
    }

    class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName + " - FullTimeEmployee");
        }
    }

    class TemporaryEmployee : Employee
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee
            {
                firstName = "Rahul",
                lastName = "Kumar"
            };
            employee.PrintFullName();

            Employee pte = new PartTimeEmployee
            {
                firstName = "Shubham",
                lastName = "Sati"
            };
            pte.PrintFullName();

            FullTimeEmployee fte = new FullTimeEmployee
            {
                firstName = "Rob",
                lastName = "Miles"
            };
            fte.PrintFullName();

            TemporaryEmployee tmp = new TemporaryEmployee
            {
                firstName = "Jon",
                lastName = "Skeet"
            };
            tmp.PrintFullName();
        }
    }
}

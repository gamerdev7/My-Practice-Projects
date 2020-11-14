using System;
using System.Collections.Generic;

namespace Delegates_Usage
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeeList, IsPromotable isEligibleToPromote)
        {
            foreach (Employee employee in employeeList)
            {
                if (Program.Promote(employee))
                {
                    Console.WriteLine($"{employee.Name} Promoted.");
                }
            }
        }
    }

    delegate bool IsPromotable(Employee emp);

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>
            {
                new Employee() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 },
                new Employee() { ID = 102, Name = "Mike", Salary = 4000, Experience = 4 },
                new Employee() { ID = 103, Name = "John", Salary = 6000, Experience = 6 },
                new Employee() { ID = 104, Name = "Todd", Salary = 3000, Experience = 3 }
            };

            IsPromotable isPromotable = new IsPromotable(Promote);
            Employee.PromoteEmployee(employeeList, isPromotable);
        }

        public static bool Promote(Employee emp)
        {
            return (emp.Experience >= 5) ? true : false;
        }
    }
}

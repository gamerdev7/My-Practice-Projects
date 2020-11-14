using System;
using System.Collections.Generic;

namespace Indexer
{
    class Employee
    {
        public int Id;
        public string Name;
        public string Country;
    }

    class MyList
    {
        private List<Employee> list;

        public MyList()
        {
            list = new List<Employee>();

            list.Add(new Employee() { Id = 1, Name = "Rob", Country = "USA" });
            list.Add(new Employee() { Id = 2, Name = "Bob", Country = "Germany" });
            list.Add(new Employee() { Id = 3, Name = "John", Country = "Russia" });
        }

        public string this[int id]   // Indexer takes Id and returns Name.
        {
            get
            {
                foreach (var employee in list)
                {
                    if (employee.Id == id)
                    {
                        return employee.Name;
                    }
                }

                return "NOT PRESENT";
            }

            set
            {
                foreach (var employee in list)
                {
                    if (employee.Id == id)
                    {
                        employee.Name = value;
                    }
                }
            }
        }

        public string this[string name] // Indexer takes Name and returns Country.
        {
            get
            {
                foreach (var employee in list)
                {
                    if (employee.Name == name)
                    {
                        return employee.Country;
                    }
                }

                return "NOT PRESENT";
            }

            set
            {
                foreach (var employee in list)
                {
                    if (employee.Name == name)
                    {
                        employee.Country = value;
                    }
                }
            }
        }

        public int this[string name, string country] // Indexer takes Name & Country and returns Id.
        {
            get
            {
                foreach (var employee in list)
                {
                    if (employee.Name == name && employee.Country == country)
                    {
                        return employee.Id;
                    }
                }

                return -1;
            }

            set
            {
                foreach (var employee in list)
                {
                    if (employee.Name == name && employee.Country == country)
                    {
                        employee.Id = value;
                    }
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyList ml = new MyList();

            Console.WriteLine($"Id = {ml["Rob", "USA"]}, Name = {ml[1]}, Country = {ml["Rob"]}");
            Console.WriteLine($"Id = {ml["Bob", "Germany"]}, Name = {ml[2]}, Country = {ml["Bob"]}");
            Console.WriteLine($"Id = {ml["John", "Russia"]}, Name = {ml[3]}, Country = {ml["John"]}");

            ml[1] = "Shubham";
            ml[2] = "Shivam";
            ml[3] = "Shekhar";

            ml["Shubham"] = "India";
            ml["Shivam"] = "Dubai";
            ml["Shekhar"] = "Italy";

            ml["Shubham", "India"] = 4;
            ml["Shivam", "Dubai"] = 5;
            ml["Shekhar", "Italy"] = 6;

            Console.WriteLine();

            Console.WriteLine($"Id = {ml["Shubham", "India"]}, Name = {ml[4]}, Country = {ml["Shubham"]}");
            Console.WriteLine($"Id = { ml["Shivam", "Dubai"]}, Name = {ml[5]}, Country = {ml["Shivam"]}");
            Console.WriteLine($"Id = { ml["Shekhar", "Italy"]}, Name = {ml[6]}, Country = {ml["Shekhar"]}");
        }
    }
}

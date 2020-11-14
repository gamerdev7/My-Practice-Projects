using System;
using System.Reflection;

namespace Reflection_Example
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer()
        {
            this.Id = -1;
            this.Name = null;
        }

        public Customer(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public void PrintId()
        {
            Console.WriteLine($"Id = {this.Id}");
        }

        public void PrintName()
        {
            Console.WriteLine($"Name = {this.Name}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Type T = Type.GetType("Reflection_Example.Customer");
            /* Type T = typeof(Customer);
               OR
               Customer C = new Customer();
               Type T = C.GetType();
            */

            Console.WriteLine($"Type's Namespace : {T.Namespace}");
            Console.WriteLine($"Type's Name : {T.Name}");
            Console.WriteLine($"Type's Full Name : {T.FullName}");

            Console.WriteLine();
            Console.WriteLine("Properties in Customer");
            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine($"{property.PropertyType.Name} {property.Name}");
            }

            Console.WriteLine();
            Console.WriteLine("Constructors in Customer");
            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("Methods in Customer");
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine($"{method.ReturnType.Name} {method.Name}");
            }

        }
    }
}

using System;
using System.Reflection;

namespace Late_Binding
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            // Creating the instance of Customer Class.
            Type customerType = executingAssembly.GetType("Late_Binding.Customer");
            object customerInstance = Activator.CreateInstance(customerType); // The type must have a default constructor. Otherwise error!

            // finding method
            MethodInfo customerGetFullNameMethod = customerType.GetMethod("GetFullName");

            // Parameters for method.
            object[] parameters = { "John", "Smith" };

            // Invoking the Method.
            string fullName = (string)customerGetFullNameMethod.Invoke(customerInstance, parameters);

            Console.WriteLine($"FullName: {fullName}");

            // For Static methods.
            MethodInfo greet = customerType.GetMethod("Greet");
            string[] name = { "Shubham" };

            greet.Invoke(1, name); // Inplace of 1 we could write any valid literal value. For eg - 3, "a", 4.3f, 6.8 
                                   // or instance of a type. For eg - new Customer().


            //Customer C = new Customer();
            //string fullName = C.GetFullName("John", "Smith");
            //Console.WriteLine($"FullName: {fullName}");
        }
    }

    class Customer
    {
        public static void Greet(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
        public string GetFullName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }

        //public Customer(int a)
        //{
        //    a = 9;
        //}
    }
}

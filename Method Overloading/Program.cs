using System;

namespace Method_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;

            Add(10, 20);
            Add(10, 20, 30);
            Add(10, 20.5f);
            Add(30, 40, out result);
            Console.WriteLine(result);
        }

        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void Add(int a, int b, int c) // overloaded based on No of parameter
        {
            Console.WriteLine(a + b + c);
        }

        static void Add(int a, float b) // overloaded based on Type of parameter
        {
            Console.WriteLine(a + b);
        }

        static void Add(int a, int b, out int result) // overloaded based on Kind of parameter
        {
            result = a + b;
        }
    }
}

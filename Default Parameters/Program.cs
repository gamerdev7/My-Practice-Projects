using System;

namespace Default_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1)); // Uses Default  values of a and b.
            Console.WriteLine(Add(1, 10)); // Uses a = 1, b = 10, c = 3.

            Console.WriteLine(Add(1, 10, 20)); // Uses a = 1, b = 10, c = 20.
            Console.WriteLine(Add(1, c: 20, b: 10)); // Uses Named Arguments and a = 1, b = 10, c = 20.
        }

        static int Add(int a, int b = 2, int c = 3)
        {
            return (a + b + c);
        }
    }
}

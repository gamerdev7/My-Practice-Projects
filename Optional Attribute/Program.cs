using System;
using System.Runtime.InteropServices;

namespace Optional_Attribute
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2));
        }

        static int Add(int a, int b, [Optional] string c)
        {
            if (c == null)
            {
                Console.WriteLine("Yes");
            }
            return (a + b);
        }
    }
}

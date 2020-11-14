#define RUN_METHOD
using System;
using System.Diagnostics;

namespace Conditional_Attribute
{
    class Program
    {
        static void Main(string[] args)
        {
            Print();
        }

        [Conditional("RUN_METHOD")]
        public static void Print()
        {
            Console.WriteLine("Hello");
        }
    }
}

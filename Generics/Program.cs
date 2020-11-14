using System;

namespace Generics
{
    class Calculator<T>
    {
        public static bool AreEqual(T val1, T val2)
        {
            return val1.Equals(val2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool areEqual = Calculator<int>.AreEqual(4, 5);
            Console.WriteLine(areEqual);
        }
    }
}

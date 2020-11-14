using System;

namespace Test
{
    class Program
    {
        public static void Main()
        {
            string a, b, c;
            a = "abd";
            b = "abcd";
        
            c = a.CompareTo(b) > 0? a : b;

            Console.WriteLine(c);

        }
    }
}
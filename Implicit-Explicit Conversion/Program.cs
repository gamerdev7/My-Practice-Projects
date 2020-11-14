using System;

namespace Implicit_Explicit_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion
            int i1 = 10;
            float f1 = i1;
            Console.WriteLine($"f1 : {f1}");

            // Explicit Conversion 1
            float f2 = -104.55f;
            int i2 = (int) f2;
            Console.WriteLine($"i2 : {i2}");

            // Explicit Conversion 2
            float f3 = -41111164.4f;
            int i3 = Convert.ToInt32(f3);
            Console.WriteLine($"i3 : {i3}");

        }
    }
}
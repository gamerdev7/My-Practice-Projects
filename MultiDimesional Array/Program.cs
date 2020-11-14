using System;

namespace MultiDimesional_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3]
            {
                {1,1,1 },
                {2,2,2 },
                { 3,3,3}
            };
            Console.WriteLine(a[2, 2]);

            int[,] b;
            b = new[,]
            {
                {1,1,1 },
                {2,2,2 },
                { 3,3,3}
            };
            Console.WriteLine(b[2, 2]);

        }
    }
}

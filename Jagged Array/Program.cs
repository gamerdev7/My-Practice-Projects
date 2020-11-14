using System;

namespace Jagged_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] a = new int[3][];
            a[0] = new int[2];
            a[1] = new int[2];
            a[2] = new int[2];

            a[0][0] = 4;

            Console.WriteLine(a[0][0]);
        }
    }
}

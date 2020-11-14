using System;

namespace Parameter_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] no = { 1, 2, 3, 4 };
            Params();
            Params(no);
            Params(34, 52, 65);
        }

        static void Params(params int[] no)
        {
            Console.WriteLine($"There are {no.Length} elements.");
            Console.WriteLine($"The elements are ...");

            foreach (int i in no)
            {
                Console.WriteLine(i);
            }
        }
    }
}

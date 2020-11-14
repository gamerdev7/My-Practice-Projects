using System;
using System.Collections.Generic;

namespace Obsolete
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(new List<int>() { 4, 3 }));
        }

        [Obsolete("Use Add(List<int> numbers) Method instead.", true)]
        public static int Add(int firstNo, int secondNo)
        {
            return firstNo + secondNo;
        }

        public static int Add(List<int> numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}

using System;
using System.Threading;

namespace Removing_Inconsistency_of_Shared_Resource_using_InterlockedIncrement
{
    class Program
    {
        static int total = 0;

        public static void Main()
        {
            Thread t1 = new Thread(AddMillion);
            Thread t2 = new Thread(AddMillion);
            Thread t3 = new Thread(AddMillion);

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine($"Total = {total}");
        }

        public static void AddMillion()
        {
            for (int i = 1; i <= 1000000; i++)
            {
                Interlocked.Increment(ref total);
            }
        }
    }
}

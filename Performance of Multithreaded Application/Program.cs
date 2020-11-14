using System;
using System.Diagnostics;
using System.Threading;

namespace Performance_of_Multithreaded_Application
{
    class Program
    {
        static void SumOfOddNo()
        {
            long sum = 0;
            for (int i = 0; i < 500000000; i++)
            {
                if (i % 2 == 1)
                {
                    sum += i;
                }
            }

            Console.WriteLine($"Sum of Odd No: {sum}");
        }

        static void SumOfEvenNo()
        {
            long sum = 0;
            for (int i = 0; i < 500000000; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine($"Sum of Even No: {sum}");
        }
        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            SumOfOddNo();
            SumOfEvenNo();
            stopwatch.Stop();
            Console.WriteLine($"Total milliseconds without Multiple Threads: {stopwatch.ElapsedMilliseconds}");

            stopwatch.Restart();
            Thread t1 = new Thread(SumOfOddNo);
            Thread t2 = new Thread(SumOfEvenNo);

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();
            stopwatch.Stop();
            Console.WriteLine($"Total milliseconds with Multiple Threads: {stopwatch.ElapsedMilliseconds}");
        }
    }
}

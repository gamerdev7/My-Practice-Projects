using System;
using System.Threading;

namespace Thread_Join___and_IsAlive__
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Thread1);
            Thread t2 = new Thread(Thread2);

            t1.Start();
            t2.Start();

            if (t1.Join(1000))
            {
                Console.WriteLine("Thread1 Method Completed.");
            }
            else
            {
                Console.WriteLine("Thread1 Method has not Completed in 1 second.");
            }

            t2.Join();
            Console.WriteLine("Thread2 Method Completed.");

            if (t1.IsAlive)
            {
                Console.WriteLine("Thread1 Method is still executing.");
            }
            else
            {
                Console.WriteLine("Thread1 Method Completed.");
            }

            Console.WriteLine("Main Completed");

        }

        public static void Thread1()
        {
            Console.WriteLine("Thread1 Method Started.");
            Thread.Sleep(5000);
            Console.WriteLine("Thread1 Method is about to return.");
        }

        public static void Thread2()
        {
            Console.WriteLine("Thread2 Method Started.");
        }
    }
}

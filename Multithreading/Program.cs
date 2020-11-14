using System;
using System.Threading;

namespace Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Print1); // implicitly converted to ThreadStart delegate.

            //Thread t2 = new Thread(Print2);
            //Thread t2 = new Thread(new ThreadStart(Print2));
            //Thread t2 = new Thread(delegate() { Print2(); });
            Thread t2 = new Thread(() => Print2());

            Thread t3 = new Thread(Print3); // implicitly converted to ParameterisedThreadStart delegate.

            t1.Start();
            t2.Start();
            t3.Start(4); // used to call ParameterisedThreadStart delegate.
        }

        static void Print1()
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Print1 - {i}");
            }
        }

        static void Print2()
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Print2 - {i}");
            }
        }

        static void Print3(object target) // signature for 
        {
            int no = Convert.ToInt32(target);
            for (int i = 1; i <= no; i++)
            {
                Console.WriteLine($"Print3 - {i}");
            }
        }
    }
}

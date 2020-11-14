using System;

namespace Delegates
{
    public delegate void HelloDelegate(string message);
    public delegate int RulesDelegate(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            HelloDelegate del = new HelloDelegate(Hello);
            del("Hello from Delegate");

            RulesDelegate rd1 = (x, y) => x + y;
            ProcessDelegate.Process(2, 3, rd1);

            RulesDelegate rd2 = (x, y) => x * y;
            ProcessDelegate.Process(2, 3, rd2);
        }

        public static void Hello(string message)
        {
            Console.WriteLine(message);
        }
    }
}

using System;

namespace Multiple_Inheritance_using_Interfaces
{
    interface IA
    {
        void PrintA();
    }

    interface IB
    {
        void PrintB();
    }

    class A : IA
    {
        public void PrintA()
        {
            Console.WriteLine("A");
        }
    }

    class B : IB
    {
        public void PrintB()
        {
            Console.WriteLine("B");
        }
    }

    class AB : IA, IB
    {
        A a = new A();
        B b = new B();

        public void PrintA()
        {
            a.PrintA();
        }

        public void PrintB()
        {
            b.PrintB();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AB ab = new AB();
            ab.PrintA();
            ab.PrintB();
        }
    }
}

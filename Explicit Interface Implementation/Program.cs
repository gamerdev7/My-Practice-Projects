using System;

namespace Explicit_Interface_Implementation
{
    interface I1
    {
        void Print();
    }

    interface I2
    {
        void Print();
    }

    interface I3
    {
        void Print();
    }

    class Program : I1, I2, I3
    {
        public void Print()
        {
            Console.WriteLine("Default Print Method");
        }

        void I1.Print()
        {
            Console.WriteLine("I1 Print Method");
        }

        void I2.Print()
        {
            Console.WriteLine("I2 Print Method");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Print();

            I1 i1 = new Program();
            i1.Print();

            I2 i2 = new Program();
            i2.Print();

            I3 i3 = new Program();
            i3.Print();
        }
    }
}

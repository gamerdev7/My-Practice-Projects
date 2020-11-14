using System;

namespace Abstract_Classes_and_Members
{
    public abstract class Customer
    {
        public abstract void Print();
    }
    class Program : Customer
    {
        public override void Print()
        {
            Console.WriteLine("Print Method");
        }

        static void Main(string[] args)
        {
            Program P = new Program();
            P.Print();

            Customer C = new Program();
            C.Print();
        }
    }
}

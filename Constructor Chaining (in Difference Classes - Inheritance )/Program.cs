using System;

namespace Constructor_Chaining__in_Difference_Classes___Inheritance__
{
    class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("BaseClass() Constructor called.");
        }

        public BaseClass(string Message)
        {
            Console.WriteLine("BaseClass(string Message) Constructor called.");
            Console.WriteLine(Message);
        }
    }

    class DerivedClass : BaseClass
    {
        public DerivedClass(string msg)
        //: base(msg)
        {
            Console.WriteLine("DerivedClass() Constructor called.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass dc = new DerivedClass("Hello!");
        }
    }
}

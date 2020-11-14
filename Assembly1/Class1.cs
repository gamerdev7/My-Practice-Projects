using System;

namespace Assembly1
{
    public class Assembly1Class1
    {
        internal int id = 100;
        protected internal string message = "Hello World";
    }

    class Assembly1Class2
    {
        public void Print()
        {
            Assembly1Class1 a1c1 = new Assembly1Class1();
            Console.WriteLine(a1c1.id);
            Console.WriteLine(a1c1.message);
        }
    }
}

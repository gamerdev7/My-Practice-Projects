using System;
using Assembly1;

namespace Assembly2
{
    class Assembly2Class1
    {

    }
    class Assembly2Class2 : Assembly1Class1
    {
        public void Print()
        {
            Assembly2Class2 a2c2 = new Assembly2Class2();
            Console.WriteLine(a2c2.message);
            Console.WriteLine(base.message);
            Console.WriteLine(this.message);
            //Console.WriteLine(a2c.id);
        }

        static void Main(string[] args)
        {
            Assembly2Class1 a2c1 = new Assembly2Class1();
            //a2c1.message();  // cannot access message bcoz Assembly2Class1 does not inherits from Assembly1Class1.

            Assembly2Class2 a2c2 = new Assembly2Class2();
            a2c2.Print();
        }
    }
}

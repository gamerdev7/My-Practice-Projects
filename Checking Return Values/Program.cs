using System;
using MPTA = MyProject.TeamA;
using MyProject.TeamB;

class Program
{
    static void Main(string[] args)
    {
        MPTA.MyClass.Print();
        MyClass.Print();
    }
}

namespace MyProject
{
    namespace TeamA
    {
        class MyClass
        {
            public static void Print()
            {
                Console.WriteLine("Team A Print Method");
            }
        }
    }
}

namespace MyProject.TeamB
{
    class MyClass
    {
        public static void Print()
        {
            Console.WriteLine("Team B Print Method");
        }
    }
}
using System;

namespace Action__Func_and_Predicate_Delegates
{
    class Program
    {
        //static void PrintMessage(string firstName, string lastName)
        //{
        //    Console.WriteLine($"Hello {firstName} {lastName}");
        //}

        //static double Add(int x, double y)
        //{
        //    return x + y;
        //}

        //static bool IsEven(int no)
        //{
        //    return no % 2 == 0;
        //}

        static void Main(string[] args)
        {
            Action<string, string> action = (firstName, lastName) =>
            Console.WriteLine($"Hello {firstName} {lastName}");

            Func<int, double, double> func = (x, y) => { return x + y; };
            Predicate<int> predicate = (no) => { return no % 2 == 0; };

            action("Shubham", "Sati");
            Console.WriteLine($"2 + 3 = {func(2, 3)}");
            Console.WriteLine(predicate(10));
        }
    }
}

using System;

namespace Switch_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int no1 = 10;
            switch (no1)
            {
                case 10:
                    Console.WriteLine("Ten");
                    break;
                case 20:
                    Console.WriteLine("Twenty");
                    break;
                case 30:
                    Console.WriteLine("Thirty");
                    break;
                default:
                    Console.WriteLine("Invalid No");
                    break;
            }

            int no2 = 10;
            switch (no2)
            {
                case 10:

                case 20:

                case 30:
                    Console.WriteLine("Thirty");
                    break;
                default:
                    Console.WriteLine("Invalid No");
                    break;
            }
        }
    }
}
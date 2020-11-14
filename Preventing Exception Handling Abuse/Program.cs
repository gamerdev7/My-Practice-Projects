using System;

namespace Preventing_Exception_Handling_Abuse
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please Enter Numerator: ");
                int numerator;
                bool isNumeratorConverted = int.TryParse(Console.ReadLine(), out numerator);

                if (isNumeratorConverted)
                {
                    Console.Write("Please Enter Denominator: ");
                    int denominator = -1;
                    bool isDenominatorConverted = int.TryParse(Console.ReadLine(), out denominator);
                    if (isDenominatorConverted && denominator != 0)
                    {
                        int result = numerator / denominator;
                        Console.WriteLine($"Result : {result}");
                    }
                    else if (isDenominatorConverted)
                    {
                        Console.WriteLine("Denominator cannot be Zero.");
                    }
                    else
                    {
                        Console.WriteLine($"Denominator should be a number between {int.MinValue} and {int.MaxValue}");
                    }
                }
                else
                {
                    Console.WriteLine($"Numinator should be a number between {int.MinValue} and {int.MaxValue}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

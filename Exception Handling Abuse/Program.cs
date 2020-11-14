using System;

namespace Exception_Handling_Abuse
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please Enter Numerator: ");
                int numerator = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please Enter Denominator: ");
                int denominator = Convert.ToInt32(Console.ReadLine());

                int result = numerator / denominator;
                Console.WriteLine($"Result - {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Number should be in between {int.MinValue} and {int.MaxValue}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Denominator cannot be Zero.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

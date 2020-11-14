using System;
using System.Threading;

namespace Retrieving_Data_from_Thread_function_using_Callback_method
{
    public delegate void SumOfNumbersCallback(int sum);

    class Number
    {
        private int no;
        private SumOfNumbersCallback callback;

        public Number(int no, SumOfNumbersCallback callback)
        {
            this.no = no;
            this.callback = callback;
        }

        public void CalculateSum()
        {
            int sum = 0;

            for (int i = 1; i <= no; i++)
            {
                sum += i;
            }

            if (this.callback != null)
            {
                callback(sum);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a no: ");
            int no = Convert.ToInt32(Console.ReadLine());

            SumOfNumbersCallback callback = PrintSum;
            Number n = new Number(no, callback);

            Thread t = new Thread(n.CalculateSum);
            t.Start();
        }

        public static void PrintSum(int sum)
        {
            Console.WriteLine($"Sum = {sum}");
        }
    }
}

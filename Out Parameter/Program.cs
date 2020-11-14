using System;

namespace Out_Parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum;

            Sum(10, 43, out sum);
            Console.WriteLine($"Sum : {sum}");
        }

        public static void Sum(int FN, int SN, out int result)
        {
            result = FN + SN;
        }
    }
}

using System;

namespace Multicast_Delegates
{
    public delegate int SampleDelegate(out int num);

    class Program
    {
        static void Main(string[] args)
        {
            SampleDelegate del1, del2, del3, del4;

            del1 = SampleMethod1;
            del2 = new SampleDelegate(SampleMethod2);
            del3 = new SampleDelegate(SampleMethod3);

            del4 = del1 + del2 + del3 - del2;
            del4 -= del3;
            del4 += del2;

            int delegateOutParameterValue;
            int delegateReturnedValue = del4(out delegateOutParameterValue);

            Console.WriteLine($"DelegateReturnedValue : {delegateReturnedValue}");
            Console.WriteLine($"DelegateOutParameterValue : {delegateOutParameterValue}");

        }

        public static int SampleMethod1(out int num1)
        {
            Console.WriteLine("SampleMethod1 Invoked");
            num1 = 1;
            return 1;
        }

        public static int SampleMethod2(out int num2)
        {
            Console.WriteLine("SampleMethod2 Invoked");
            num2 = 2;
            return 2;
        }

        public static int SampleMethod3(out int num3)
        {
            Console.WriteLine("SampleMethod3 Invoked");
            num3 = 3;
            return 3;
        }
    }
}

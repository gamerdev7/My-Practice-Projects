using System;
using System.Threading;

namespace Passing_Data_to_Thread_function_in_Type_Safe_manner
{
    class Number
    {
        private int no;

        public Number(int no)
        {
            this.no = no;
        }

        public void Print()
        {
            for (int i = 1; i <= no; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a no: ");
            int no = Convert.ToInt32(Console.ReadLine());

            Number n = new Number(no);

            Thread t = new Thread(new ThreadStart(n.Print));
            t.Start();
        }
    }
}

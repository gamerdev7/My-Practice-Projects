using System;

namespace _Convert.ToString___VS_ToString__
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = null;
            string name1 = Convert.ToString(name);
            Console.WriteLine(name1);
            string name2 = name.ToString();
            Console.WriteLine(name2);
        }
    }
}

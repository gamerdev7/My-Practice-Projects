using System;

namespace Parse___and_TryParse___methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*// Parse
            string no1 = "100AB";
            int i1 = int.Parse(no1);
            Console.WriteLine(i1);
            */
            // TryParse
            string no2 = "34";
            bool isConverted = int.TryParse(no2, out int i2);
            Console.WriteLine(isConverted);
            Console.WriteLine(i2);
        }
    }
}

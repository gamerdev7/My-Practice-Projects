using System;
using System.IO;

namespace StreamReader_and_StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs1 = new FileStream("temp.txt", FileMode.OpenOrCreate, FileAccess.Write);

            using (StreamWriter writer = new StreamWriter(fs1))
            {
                writer.WriteLine("Written by StreamWriter.");
            }

            FileStream fs2 = new FileStream("temp.txt", FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs2))
            {
                Console.WriteLine(reader.ReadToEnd());
            }

        }

    }
}
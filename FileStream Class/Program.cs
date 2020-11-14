using System;
using System.IO;
using System.Text;
namespace FileStream_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            // Writing bytes to a file.
            using (FileStream fs = new FileStream("temp.txt", FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = Encoding.ASCII.GetBytes("Hello World"); // Store what you want to write in byte array
                fs.Write(buffer, 0, buffer.Length);                    // and write into file using that byte array.
            }

            // Reading bytes from a file.
            using (FileStream fs = new FileStream("temp.txt", FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[fs.Length];
                int byteRead = fs.Read(buffer, 0, buffer.Length);

                Console.WriteLine(Encoding.ASCII.GetString(buffer));
            }
        }
    }
}


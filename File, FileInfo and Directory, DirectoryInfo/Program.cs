using System;
using System.IO;

namespace File__FileInfo_and_Directory__DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // File Class
            Console.WriteLine("--------------File Class--------------");
            if (File.Exists(@"Files\temp.txt"))
            {
                File.Copy(@"Files\temp.txt", @"Files\copy1.txt", true);
                File.Delete(@"Files\copy1.txt");
                string[] lines = File.ReadAllLines(@"Files\temp.txt");
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("File does not exists.");
            }
            Console.WriteLine("--------------File Class--------------");

            // FileInfo Class
            Console.WriteLine("--------------FileInfo Class--------------");

            FileInfo fi = new FileInfo(@"Files\temp.txt");
            if (fi.Exists)
            {
                fi.CopyTo(@"Files\copy2.txt", true);
                Console.WriteLine($"File Created on: {fi.CreationTime}");
                Console.WriteLine($"File is present in : {fi.Directory}");

                //fi.Delete();
            }
            else
            {
                Console.WriteLine("File does not exists.");
            }
            Console.WriteLine("--------------FileInfo Class--------------");

            // Directory Class
            Console.WriteLine("--------------Directory Class--------------");

            if (Directory.Exists("Files"))
            {
                string[] files = Directory.GetFiles("Files", "*.*", SearchOption.AllDirectories);
                Console.WriteLine("File Names...");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }

                string[] directories = Directory.GetDirectories("Files", "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Directory Names...");
                foreach (string directory in directories)
                {
                    Console.WriteLine(directory);
                }
                Console.WriteLine("--------------Directory Class--------------");

            }
            else
            {
                Console.WriteLine("Directory does not exists.");
            }

            // DirectoryInfo Class
            Console.WriteLine("--------------DirectoryInfo Class--------------");

            DirectoryInfo di = new DirectoryInfo("Files");
            if (di.Exists)
            {
                var files = di.GetFiles("*.*", SearchOption.AllDirectories);
                Console.WriteLine("File Names...");
                foreach (var file in files)
                {
                    Console.WriteLine(file);
                }

                var directories = di.GetDirectories("*.*", SearchOption.AllDirectories);
                Console.WriteLine("Directory Names...");
                foreach (var directory in directories)
                {
                    Console.WriteLine(directory);
                }
            }
            else
            {
                Console.WriteLine("Directory does not exists.");
            }
            Console.WriteLine("--------------DirectoryInfo Class--------------");
        }
    }
}

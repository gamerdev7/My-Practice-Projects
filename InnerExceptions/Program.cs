using System;
using System.IO;

namespace InnerExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.Write("Enter First no: ");
                    int firstNo = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Second no: ");
                    int secondNo = Convert.ToInt32(Console.ReadLine());

                    int result = firstNo / secondNo;
                    Console.WriteLine($"Result : {result}");
                }
                catch (Exception e)
                {
                    string path = "log.txt";
                    if (File.Exists(path))
                    {
                        StreamWriter writer = new StreamWriter(path);
                        writer.WriteLine($"{e.GetType().Name} - {e.Message}");
                        writer.Close();
                        Console.WriteLine("There is a problem, Please try again later.");
                    }
                    else
                    {
                        throw new FileNotFoundException($"{path} is not present.", e);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Current Exception : {ex.GetType().Name}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception : {ex.InnerException.GetType().Name}");
                }

            }
        }
    }
}


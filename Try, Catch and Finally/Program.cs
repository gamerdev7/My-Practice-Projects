using System;
using System.IO;

namespace Try__Catch_and_Finally
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = null;
            try
            {
                reader = new StreamReader("Data.txt");
                Console.WriteLine(reader.ReadToEnd());
            }
            catch (FileNotFoundException e)
            {

                Console.WriteLine($"Please check if the file {e.FileName} exists");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }

        }
    }
}

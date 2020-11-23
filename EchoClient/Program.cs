using System;
using System.IO;
using System.Net;
using System.Net.Sockets;


namespace EchoClient
{
    class Client
    {
        static void Main(string[] args)
        {
            Console.Title = "EchoClient";
            try
            {
                TcpClient client = new TcpClient("127.0.0.1", 7777);
               
                using (StreamReader reader = new StreamReader(client.GetStream()))
                {
                    using (StreamWriter writer = new StreamWriter(client.GetStream()))
                    {
                        string s = string.Empty;

                        while (!s.Equals("exit"))
                        {
                            Console.Write("Enter a string to send to the server: ");
                            s = Console.ReadLine();
                            Console.WriteLine();
                            writer.WriteLine(s);
                            writer.Flush();
                            string serverString = reader.ReadLine();
                            Console.WriteLine(serverString);
                        }
                    }
                }

                client.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

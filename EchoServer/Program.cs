using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace EchoServer
{
    class Server
    {
        static void Main(string[] args)
        {
            Console.Title = "EchoServer";
            TcpListener listener = null;

            try
            {
                listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 7777);
                listener.Start();
                Console.WriteLine("Echo Server Started...");

                while (true)
                {
                    Console.WriteLine("Waiting for incoming client connection...");
                    TcpClient client = listener.AcceptTcpClient();
                    Console.WriteLine("Accepted new client connnection...");
                   
                    using (StreamReader reader = new StreamReader(client.GetStream()))
                    {
                        using (StreamWriter writer = new StreamWriter(client.GetStream()))
                        {
                            string s = string.Empty;

                            while (!((s = reader.ReadLine()).Equals("exit") || (s == null)))
                            {
                                Console.WriteLine($"From Client -> {s}");
                                writer.WriteLine($"From Server -> {s}");
                                writer.Flush();
                            }
                        }
                    }

                    client.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                listener?.Stop();
            }
        }
    }
}

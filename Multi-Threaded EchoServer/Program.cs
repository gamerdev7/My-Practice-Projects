using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Multi_Threaded_EchoServer
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

                    Thread t = new Thread(ProcessClientRequests);
                    t.Start(client);
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

        private static void ProcessClientRequests(object clientObj)
        {
            TcpClient client = (TcpClient)clientObj;

            try
            {
                while (true)
                {
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
                client?.Close();
            }
        }
    }
}

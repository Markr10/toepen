using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace consoleServer
{
    class Program
    {
        private static IPAddress IP;

        public static void Main(string[] args)
        {
            getIp();
            Console.WriteLine("Multi-Threaded TCP Server");
            Console.WriteLine("IPAddress: " + getIp().ToString());
            Console.WriteLine("Port: 5342");
            Server server = new Server(5342);
        }



       /* private static Thread serverThread;
        private static Thread exitThread;
        private static Thread socketThread;
        private static IPAddress ipAdress;
        private static TcpListener myList;
        private static string serverIP;


        public static void Main(string[] args)
        {
            serverIP = "10.110.110.167"; // getIp();

            ipAdress = IPAddress.Parse(serverIP);

            // Initializes the Listener
            myList = new TcpListener(ipAdress, 5431);

            serverThread = new Thread(new ThreadStart(runServer));
            serverThread.Start();
            exitThread = new Thread(stopServer);
            exitThread.Start();
            
            
        }

        public static void stopServer()
        {
            while (true)
            {
                String str = Console.ReadLine();

                if (str == "exit")
                {
                    myList.Stop();
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Command not found!");
                }
            }
        }

        public static void runServer()
        {
            
            try
            {

                

                // Start listening
                myList.Start();

                Console.WriteLine(">> Server running.....");
                Console.WriteLine(">> Ip address: " + serverIP);
                Console.WriteLine(">> Port: 5431");
                Console.WriteLine(">> Waiting for connections...");

                while(true)
                {

                    socketThread = new Thread(runSocket);
                    socketThread.Start();

                    
                    
                }

                
            }
            catch (Exception e)
            {
                Console.WriteLine("Error.... ", e.StackTrace);
            }
        }

        public static void runSocket()
        {
                    Socket s = myList.AcceptSocket();

                    
                    //when accepted
                    Console.WriteLine("Connection accepted from " + s.LocalEndPoint);

                    byte[] b = new byte[100];
                    int k = s.Receive(b);
                    Console.WriteLine(">> Received...");

                    for (int i = 0; i < k; i++)
                    {
                        Console.Write(Convert.ToChar(b[i]));
                    }

                    ASCIIEncoding asen = new ASCIIEncoding();
                    s.Send(asen.GetBytes("Automatic message: String received by server!"));
                    Console.WriteLine("\n Automatic message sent!");


                    s.Close();
        }*/

        public static IPAddress getIp()
        {
            string strHostName = "";
            strHostName = System.Net.Dns.GetHostName();

            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);

            IPAddress[] addr = ipEntry.AddressList;

            IP = addr[2];

            return IP;
        }
    }
}

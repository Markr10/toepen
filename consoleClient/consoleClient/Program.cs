using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace consoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                TcpClient tcpclnt = new TcpClient();
                 
                Console.WriteLine(">> Connecting");

                //same ip as in server programm
                tcpclnt.Connect("10.111.200.73", 5431);

                Console.WriteLine(">> Connected...");



                Console.WriteLine(tcpclnt.Client.LocalEndPoint);
                    Console.Write(">> Enter the string to be sent: ");

                    String str = Console.ReadLine();
                    Stream stm = tcpclnt.GetStream();


                        ASCIIEncoding asen = new ASCIIEncoding();
                        byte[] ba = asen.GetBytes(str);
                        Console.WriteLine(">> Sending...");

                        stm.Write(ba, 0, ba.Length);

                        byte[] bb = new byte[100];

                        int k = stm.Read(bb, 0, 100);

                        for (int i = 0; i < k; i++)
                        {
                            Console.Write(Convert.ToChar(bb[i]));
                        }

                        
                  
                        tcpclnt.Close();
                       
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error.... {0}", e.StackTrace);
            }

        }
    }
}

﻿using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace consoleServer
{
    class Server
    {
        private TcpListener _server;
        private Boolean _isRunning;
        private static ArrayList connectedClients;

        // proef om alle threads melding te geven
        private static EventWaitHandle _waitHandle = new EventWaitHandle (false, EventResetMode.ManualReset);
        private ArrayList threads;

        public Server(int port)
        {
            connectedClients = new ArrayList();
            _server = new TcpListener(IPAddress.Any, port);
            _server.Start();

            _isRunning = true;

            threads = new ArrayList();

            LoopClients();

        }


        public void LoopClients()
        {
            while (_isRunning)
            {
                // wait for client connection, then go further
                TcpClient newClient = _server.AcceptTcpClient();

                

                // client found.
                // create a thread to handle communication
                Thread t = new Thread(new ParameterizedThreadStart(HandleClient));
                t.Start(newClient);
                threads.Add(t);
                if (threads.Count >= 2)
                {
                    Thread.Sleep(10000);
                    _waitHandle.Set();
                }
            }
        }

        public void HandleClient(object obj)
        {
            // retrieve client from parameter passed to thread
            TcpClient client = (TcpClient)obj;

            String ipClient = client.Client.LocalEndPoint.ToString();

            var output = ipClient.Split(new[] { ':', ' ' });
            
            connectedClients.Add(output[0].ToString());
           

            // sets two streams
            StreamWriter sWriter = new StreamWriter(client.GetStream(), Encoding.ASCII);
            StreamReader sReader = new StreamReader(client.GetStream(), Encoding.ASCII);
            // you could use the NetworkStream to read and write, 
            // but there is no forcing flush, even when requested

            Boolean bClientConnected = true;
            
            String sData = null;

            while (bClientConnected)
            {
                try
                {
                    // reads from stream
                    sData = sReader.ReadLine();

                    PlayCard playCard = JsonConvert.DeserializeObject<PlayCard>(sData);

                    // shows content on the console.
                    Console.WriteLine(playCard.Name + "> " + playCard.Card);
                    
                    //string response = Console.ReadLine();
                    //// to write something back.
                    //sWriter.WriteLine(response);
                    _waitHandle.WaitOne();
                    Console.WriteLine("Send to" + playCard.Name);
                    sWriter.WriteLine("Notified");
                    sWriter.Flush();

                }
                catch (Exception)
                {
                    Console.WriteLine("Connection lost!");
                    Thread.Sleep(5000);
                    bClientConnected = false;
                    Environment.Exit(0);
                    // Schakel thread uit wanneer connection is lost.
                    
                }
            }
        }
    }

}

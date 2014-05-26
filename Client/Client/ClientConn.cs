using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace consoleClient
{
    class ClientConn
    {
        private TcpClient _client;

        private StreamReader _sReader;
        private StreamWriter _sWriter;

        private Boolean _isConnected;

        public ClientConn(String ipAddress, int portNum)
        {
            _client = new TcpClient();
            _client.Connect(ipAddress, portNum);
            
            //HandleCommunication(name);
        }

        public void HandleCommunication(object text)
        {
            _sReader = new StreamReader(_client.GetStream(), Encoding.ASCII);
            _sWriter = new StreamWriter(_client.GetStream(), Encoding.ASCII);

            _isConnected = true;
            //String sData = null;
            while (_isConnected)
            {
                
                // write data and make sure to flush, or the buffer will continue to 
                // grow, and your data might not be sent when you want it, and will
                // only be sent once the buffer is filled.
                //_sWriter.WriteLine(sData);
               
                _sWriter.WriteLine(text);
                
                _sWriter.Flush();
                _isConnected = false;


                // if you want to receive anything
                // String sDataIncomming = _sReader.ReadLine();
            }
        }
    }
}

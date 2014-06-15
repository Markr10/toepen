using consoleClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        ClientConn client;
        private static string name;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

           
            //string ip = ipadres.Text;
            string ip = "127.0.0.1";

            Console.WriteLine("Provide Port:");
           // int port = Int32.Parse(poort.Text);
            int port = 5342;

            client = new ClientConn(ip, port);
            
            
        }

        private void ip_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Messages bericht = new Messages();
            bericht.Name = SystemInformation.ComputerName;
            bericht.Message = invoer.Text;

            client.HandleCommunication(JsonConvert.SerializeObject(bericht));

        }

        private void response_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            response.Text = client.getResponse();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    
    public partial class Client : Form
    {
        IPEndPoint iep;
        Socket client;
        public Client()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            iep = new IPEndPoint(IPAddress.Parse("192.168.1.5"), 1234);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            client.Connect(iep);
            Console.WriteLine("Connected to server");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[1024];
            data = Encoding.ASCII.GetBytes(rTB1.Text);
            listBox1.Items.Add("Server: " + rTB1.Text);
            rTB1.Text = "";
            client.Send(data);
            data = new byte[1024];
            client.Receive(data);
            listBox1.Items.Add("Server: " + Encoding.ASCII.GetString(data));
        }
    }
}

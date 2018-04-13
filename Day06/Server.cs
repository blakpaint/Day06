using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day06
{
    public partial class Server : Form
    {
        Socket server, client;
        byte[] data = new byte[1024];

        public Server()
        {
            InitializeComponent();
        }

        private void Server_Load(object sender, EventArgs e)
        {
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse("192.168.1.5"), 1234);
            server.Bind(iep);
            server.Listen(10);
            server.BeginAccept(new AsyncCallback(AcceptClient), server);
        }

        private void AcceptClient(IAsyncResult i)
        {
            client = ((Socket)i.AsyncState).EndAccept(i);
            Thread thr = new Thread(new ThreadStart(recvDataThr));
            thr.Start();
        }

        private void recvDataThr()
        {
            client.BeginReceive(data, 0, data.Length, SocketFlags.None, new AsyncCallback(recvData), client);
        }

        private void recvData(IAsyncResult i)
        {
            ((Socket)i.AsyncState).EndReceive(i);
            listBox1.Items.Add("Client: " + Encoding.ASCII.GetString(data));
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = @"D:\";//Thư mục mặc định khi mở
            file.Filter = "All files (*.*)|*.*|exe files (*.txt)|*.txt";// Lọc ra những file cần hiển thị
            file.RestoreDirectory = true;

            if (file.ShowDialog() == DialogResult.OK)
            {
                rTB1.Text = file.FileName;
            }
        }

        private void btnMusic_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = @"D:\";//Thư mục mặc định khi mở
            file.Filter = "(*.mp3)|*.mp3|(*.wma)|*.wma|(*.wav)|*.wav|(*.m4a)|*.m4a|All files(*.*)|*.*";// Lọc ra những file cần hiển thị
            file.RestoreDirectory = true;

            if (file.ShowDialog() == DialogResult.OK)
            {
                rTB1.Text = file.FileName;
            }
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = @"c:\";//Thư mục mặc định khi mở
            file.Filter = "(*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.png)|*.png|(*.gif)|*.gif|(*.ico)|*.ico|All files (*.*)|*.*";// Lọc ra những file cần hiển thị
            file.RestoreDirectory = true;

            if (file.ShowDialog() == DialogResult.OK)
            {
                rTB1.Text = file.FileName;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string text = rTB1.Text;
            listBox1.Items.Add("Server: " + text);
            rTB1.Text = "";
            data = new byte[1024];
            data = Encoding.ASCII.GetBytes(text);
            client.Send(data);
            data = new byte[1024];
            client.Receive(data);
            listBox1.Items.Add("Client: " + Encoding.ASCII.GetString(data));
        }
    }
}

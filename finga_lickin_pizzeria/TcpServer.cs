using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTCP;
using System.Net;

namespace finga_lickin_pizzeria
{
    public partial class TcpServer : Form
    {
        SimpleTcpServer server;

        public TcpServer()
        {
            InitializeComponent();
        }

        private void TcpServer_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            statusTextBox.Invoke((MethodInvoker)delegate ()
            {
                statusTextBox.Text += e.MessageString;
                e.ReplyLine(string.Format("You said: {0}", e.MessageString));
            });
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            statusTextBox.Text += "Server starting...";
            System.Net.IPAddress ip = System.Net.IPAddress.Any;
            server.Start(ip, Convert.ToInt32(portTextBox.Text));
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
            {
                server.Stop();
            }
        }
    }
}

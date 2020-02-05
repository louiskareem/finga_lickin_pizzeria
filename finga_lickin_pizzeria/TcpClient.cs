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
    public partial class TcpClient : Form
    {
        SimpleTcpClient client;

        public TcpClient()
        {
            InitializeComponent();
        }

        private void TcpClient_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
            var order = string.Join(Environment.NewLine, CashierView.orderList);
            messageTextBox.Text = order;

        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            statusListBox.Invoke((MethodInvoker)delegate ()
            {
                statusListBox.Items.Add(CashierView.orderList.ToString());
                statusListBox.Items.Add(e.MessageString);
                //statusTextBox.Text += e.MessageString;
            });
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            connectButton.Enabled = false;
            client.Connect(hostTextBox.Text, Convert.ToInt32(portTextBox.Text));
        }

        private void sendButton_Click(object sender, EventArgs e)
        {

            client.WriteLineAndGetReply(messageTextBox.Text, TimeSpan.FromSeconds(3));
        }
    }
}

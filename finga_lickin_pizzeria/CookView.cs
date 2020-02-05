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
using System.Text.RegularExpressions;
using System.IO.Ports;
using System.Net.Sockets;
using System.Threading;
using System.Diagnostics;

namespace finga_lickin_pizzeria
{
    public partial class CookView : Form
    {
        WebSocket ws;
        SerialPort port;
        public static List<string> orderDetailsList = new List<string>();

        public CookView()
        {
            InitializeComponent();
            ws = new WebSocket();

        }

        private void CookView_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        public void stopArduino()
        {
            if (port != null && port.IsOpen)
            {
                timer1.Stop();
                btnConnArduino.Enabled = true;
                string message;
                message = port.ReadLine();
                MessageBox.Show("Order № " + message + "done ");
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            orderDetailsListBox.Items.Clear();
            foreach (string st in Regex.Split(ws.messages.ToString(), "\n"))
            {

                orderDetailsListBox.Items.Add(st);
            }
            stopArduino();

            foreach (var item in ws.messages)
            {
                orderDetailsListBox.Items.Add(item);
            }
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            orderDetailsList.Add("DONE");
            var orderDetails = string.Join(Environment.NewLine, orderDetailsList);

            ClientTableView form3 = new ClientTableView();
            form3.Show();
            timer1.Stop();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            ws.connect(textBoxLocalIP.Text, textBoxLocalPort.Text, textBoxRemotIP.Text, textBoxRemotePort.Text);
            MessageBox.Show("Connection has been established. Now you can start sending messages. ");

            var order = string.Join(Environment.NewLine, CashierView.orderList);
            orderDetailsListBox.Items.Clear();
            foreach (string st in Regex.Split(order, "\n"))
            {

                orderDetailsListBox.Items.Add(st);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (port == null)
            {
                port = new SerialPort("COM10", 9600, Parity.None, 8, StopBits.One);
                port.Open();
            }
            timer1.Start();
            btnConnArduino.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnDisconnArduino.Enabled = false;
        }
    }
}

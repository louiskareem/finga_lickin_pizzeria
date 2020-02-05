using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Sockets;

namespace finga_lickin_pizzeria
{
    public partial class ClientTableView : Form
    {

        public ClientTableView()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var order = string.Join(Environment.NewLine, CashierView.orderList);
            foreach (string s in Regex.Split(order, "\n"))

                clientTableListBox.Items.Add(s);
                clientTableListBox.Items.Add("Preparing");


            var orderd = string.Join(Environment.NewLine, CookView.orderDetailsList);

            foreach (string st in Regex.Split(orderd, "\n"))
            {
                if (st == "DONE")
                {
                    clientTableListBox.Items.RemoveAt(clientTableListBox.Items.Count - 1);
                    clientTableListBox.Items.Add("Pizza is Done");
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}

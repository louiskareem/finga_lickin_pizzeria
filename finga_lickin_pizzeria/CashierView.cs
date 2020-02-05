using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SimpleTCP;
using System.Net;
using System.IO.Ports;
using System.Threading;
using System.Text.RegularExpressions;
using System.Net.Sockets;

namespace finga_lickin_pizzeria
{
    public partial class CashierView : Form
    {
        public static List<string> orderList = new List<string>();
        public static List<string> conn = new List<string>();
        CookView form2 = new CookView();
        WebSocket ws;

        public CashierView()
        {
            InitializeComponent();
            ws = new WebSocket();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CookView form2 = new CookView();
            form2.Show();
        }

        // Method to get the euro sign in c# without hardcoding it 
        public static char HexToChar(string hex)
        {
            return (char)ushort.Parse(hex, System.Globalization.NumberStyles.HexNumber);
        }

        // Method to run when order button is clicked, first check if everything is checked and clicked then continue executing 
        private void orderButton_Click(object sender, EventArgs e)
        {
            orderList.Add(orderNumTextBox.Text);

            foreach (Control control in pizzaPanel.Controls)
            {
                if (control.GetType() == typeof(RadioButton))
                {
                    RadioButton radio = control as RadioButton;
                    if (radio.Checked)
                    {
                        orderList.Add(radio.Text);
                    }
                }

                if(control.GetType() == typeof(TextBox))
                {
                    TextBox textbox = control as TextBox;
                    switch (textbox.Text)
                    {
                        case "pepPriceTxtBox":
                            orderList.Add(textbox.Text);
                            break;
                        case "gyrPriceTxtBox":
                            orderList.Add(textbox.Text);
                            break;
                        case "marPriceTxtBox":
                            orderList.Add(textbox.Text);
                            break;
                        case "morPriceTxtBox":
                            orderList.Add(textbox.Text);
                            break;
                        case "hawPriceTxtBox":
                            orderList.Add(textbox.Text);
                            break;
                    }
                }
            }

            foreach (Control control in extraGroupBox.Controls)
            {
                if (control.GetType() == typeof(RadioButton))
                {
                    RadioButton radio = control as RadioButton;
                    if(radio.Checked)
                    {
                        orderList.Add(radio.Text);
                    }
                }

                if (control.GetType() == typeof(ComboBox))
                {
                    ComboBox combo = control as ComboBox;
                    //double addedAmount = Convert.ToDouble( amountTxtBox.Text ) + 2.50;
                    if(combo.SelectedIndex > -1)
                    {
                        switch (combo.SelectedItem.ToString())
                        {
                            case "Coca - Cola":
                                orderList.Add(combo.Text);
                                break;
                            case "Fanta Orange":
                                orderList.Add(combo.Text);
                                //orderList.Add(amountTxtBox.Text += "2,50");
                                //orderList.Add(Convert.ToDouble(amountTxtBox.Text) += 2, 50);
                                break;
                            case "Fanta Purple":
                                orderList.Add(combo.Text);
                                //orderList.Add(Convert.ToDouble(amountTxtBox.Text) += 2, 50);
                                break;
                            case "Fuze Tea":
                                orderList.Add(combo.Text);
                                //orderList.Add(Convert.ToDouble(amountTxtBox.Text) += 2, 50);
                                break;
                            case "Sprite":
                                orderList.Add(combo.Text);
                                //orderList.Add(Convert.ToDouble(amountTxtBox.Text) += 2, 50);
                                break;
                            case "Cola Cherry":
                                orderList.Add(combo.Text);
                                //orderList.Add(Convert.ToDouble(amountTxtBox.Text) += 2, 50);
                                break;
                            case "Beer":
                                orderList.Add(combo.Text);
                                //orderList.Add(Convert.ToDouble(amountTxtBox.Text) += 2, 50);
                                break;
                            case "Wine":
                                orderList.Add(combo.Text);
                                //orderList.Add(Convert.ToDouble(amountTxtBox.Text) += 2, 50);
                                break;
                            case "Whiskey":
                                orderList.Add(combo.Text);
                                //orderList.Add(Convert.ToDouble(amountTxtBox.Text) += 2, 50);
                                break;
                            case "Cognac":
                                orderList.Add(combo.Text);
                                //orderList.Add(Convert.ToDouble(amountTxtBox.Text) += 2, 50);
                                break;
                            case "Paprika":
                                orderList.Add(combo.Text);
                                //orderList.Add(Convert.ToDouble(amountTxtBox.Text) += 2, 50);
                                break;
                            case "Extra Cheese":
                                orderList.Add(combo.Text);
                                //orderList.Add(Convert.ToDouble(amountTxtBox.Text) += 2, 50);
                                break;
                            case "Extra Chicken":
                                orderList.Add(combo.Text);
                                //orderList.Add(Convert.ToDouble(amountTxtBox.Text) += 2, 50);
                                break;
                            case "Thick Crust":
                                orderList.Add(combo.Text);
                                //orderList.Add(Convert.ToDouble(amountTxtBox.Text) += 2, 50);
                                break;
                            case "Onions":
                                orderList.Add(combo.Text);
                                //orderList.Add(Convert.ToDouble(amountTxtBox.Text) += 2, 50);
                                break;
                            case "Garlic Pepper":
                                orderList.Add(combo.Text);
                                //orderList.Add(Convert.ToDouble(amountTxtBox.Text) += 2, 50);
                                break;
                            case "Cream Cheese":
                                orderList.Add(combo.Text);
                                //orderList.Add(Convert.ToDouble(amountTxtBox.Text) += 2, 50);
                                break;
                        } 
                    }
                }
            }

            orderList.Add(amountTxtBox.Text);
            var order = string.Join(Environment.NewLine, orderList);
            string t = textBox1.Text = order;
            ws.sendMsg(t);

            ClientTableView form3 = new ClientTableView();
            form3.Show();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            ws.connect(textBoxLocalIP.Text, textBoxLocalPort.Text, textBoxRemotIP.Text, textBoxRemotePort.Text);
            MessageBox.Show("Connection has been established. Now you can start sending messages. ");
        }

        // Send the order to the cook view via websockets 
        private void buttonMessage_Click(object sender, EventArgs e)
        {
            //send the msg

            ws.sendMsg(textBox1.Text);
            CookView form2 = new CookView();
            form2.Show();
        }

        private void pepRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            amountTxtBox.Text = HexToChar("20AC") + " " + pepPriceTextBox.Text;
        }

        private void gyrRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            amountTxtBox.Text = HexToChar("20AC") + " " + gyrPriceTextBox.Text;
        }

        private void marRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            amountTxtBox.Text = HexToChar("20AC") + " " + marPriceTextBox.Text;
        }

        private void morRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            amountTxtBox.Text = HexToChar("20AC") + " " + morPriceTextBox.Text;
        }

        private void hawRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            amountTxtBox.Text = HexToChar("20AC") + " " + hawPriceTextBox.Text;
        }
    }
}

namespace finga_lickin_pizzeria
{
    partial class CookView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CookView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.orderDetailsListBox = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.doneButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRemotePort = new System.Windows.Forms.TextBox();
            this.textBoxRemotIP = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelIP = new System.Windows.Forms.Label();
            this.textBoxLocalPort = new System.Windows.Forms.TextBox();
            this.textBoxLocalIP = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConnArduino = new System.Windows.Forms.Button();
            this.btnDisconnArduino = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.groupBox1.Controls.Add(this.orderDetailsListBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 535);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Details";
            // 
            // orderDetailsListBox
            // 
            this.orderDetailsListBox.FormattingEnabled = true;
            this.orderDetailsListBox.ItemHeight = 16;
            this.orderDetailsListBox.Location = new System.Drawing.Point(21, 21);
            this.orderDetailsListBox.Name = "orderDetailsListBox";
            this.orderDetailsListBox.Size = new System.Drawing.Size(328, 500);
            this.orderDetailsListBox.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM10";
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(131, 553);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(105, 51);
            this.doneButton.TabIndex = 14;
            this.doneButton.Text = "DONE";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.buttonConnect);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(500, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(554, 534);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RECEIVER";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(417, 69);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(1);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(119, 65);
            this.buttonConnect.TabIndex = 9;
            this.buttonConnect.Text = "CONNECT";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.ForestGreen;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBoxRemotePort);
            this.groupBox3.Controls.Add(this.textBoxRemotIP);
            this.groupBox3.Location = new System.Drawing.Point(225, 24);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox3.Size = new System.Drawing.Size(184, 150);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Friend";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "IP";
            // 
            // textBoxRemotePort
            // 
            this.textBoxRemotePort.Location = new System.Drawing.Point(60, 86);
            this.textBoxRemotePort.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxRemotePort.Name = "textBoxRemotePort";
            this.textBoxRemotePort.Size = new System.Drawing.Size(111, 22);
            this.textBoxRemotePort.TabIndex = 3;
            this.textBoxRemotePort.Text = "8910";
            // 
            // textBoxRemotIP
            // 
            this.textBoxRemotIP.Location = new System.Drawing.Point(60, 46);
            this.textBoxRemotIP.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxRemotIP.Name = "textBoxRemotIP";
            this.textBoxRemotIP.Size = new System.Drawing.Size(111, 22);
            this.textBoxRemotIP.TabIndex = 2;
            this.textBoxRemotIP.Text = "192.168.43.165";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.LabelIP);
            this.groupBox4.Controls.Add(this.textBoxLocalPort);
            this.groupBox4.Controls.Add(this.textBoxLocalIP);
            this.groupBox4.Location = new System.Drawing.Point(16, 24);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox4.Size = new System.Drawing.Size(201, 150);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Me";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Port";
            // 
            // LabelIP
            // 
            this.LabelIP.AutoSize = true;
            this.LabelIP.Location = new System.Drawing.Point(36, 48);
            this.LabelIP.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LabelIP.Name = "LabelIP";
            this.LabelIP.Size = new System.Drawing.Size(20, 17);
            this.LabelIP.TabIndex = 4;
            this.LabelIP.Text = "IP";
            // 
            // textBoxLocalPort
            // 
            this.textBoxLocalPort.Location = new System.Drawing.Point(69, 86);
            this.textBoxLocalPort.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxLocalPort.Name = "textBoxLocalPort";
            this.textBoxLocalPort.Size = new System.Drawing.Size(111, 22);
            this.textBoxLocalPort.TabIndex = 1;
            this.textBoxLocalPort.Text = "8910";
            // 
            // textBoxLocalIP
            // 
            this.textBoxLocalIP.Location = new System.Drawing.Point(72, 46);
            this.textBoxLocalIP.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxLocalIP.Name = "textBoxLocalIP";
            this.textBoxLocalIP.Size = new System.Drawing.Size(111, 22);
            this.textBoxLocalIP.TabIndex = 0;
            this.textBoxLocalIP.Text = "192.168.43.158";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(542, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnConnArduino
            // 
            this.btnConnArduino.Location = new System.Drawing.Point(552, 553);
            this.btnConnArduino.Name = "btnConnArduino";
            this.btnConnArduino.Size = new System.Drawing.Size(181, 46);
            this.btnConnArduino.TabIndex = 16;
            this.btnConnArduino.Text = "CONNECT ARDUINO";
            this.btnConnArduino.UseVisualStyleBackColor = true;
            this.btnConnArduino.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDisconnArduino
            // 
            this.btnDisconnArduino.Location = new System.Drawing.Point(849, 553);
            this.btnDisconnArduino.Name = "btnDisconnArduino";
            this.btnDisconnArduino.Size = new System.Drawing.Size(187, 46);
            this.btnDisconnArduino.TabIndex = 17;
            this.btnDisconnArduino.Text = "DISCONNECT ARDUINO";
            this.btnDisconnArduino.UseVisualStyleBackColor = true;
            this.btnDisconnArduino.Click += new System.EventHandler(this.button2_Click);
            // 
            // CookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1068, 611);
            this.Controls.Add(this.btnDisconnArduino);
            this.Controls.Add(this.btnConnArduino);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "CookView";
            this.Text = "KDS (For the Cook)";
            this.Load += new System.EventHandler(this.CookView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox orderDetailsListBox;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRemotePort;
        private System.Windows.Forms.TextBox textBoxRemotIP;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelIP;
        private System.Windows.Forms.TextBox textBoxLocalPort;
        private System.Windows.Forms.TextBox textBoxLocalIP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConnArduino;
        private System.Windows.Forms.Button btnDisconnArduino;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
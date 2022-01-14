using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Net;
using System.Net.Mail;

namespace smart_home_security_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();  //Seri portları diziye ekleme
            foreach (string port in ports)
            comboBox1.Items.Add(port);
            pictureBox3.Visible = false;
            
        }

        private void connection_btn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            groupBox1.Enabled = true;
            try
            {
                if (!serialPort1.IsOpen)
                {
                    /* Seri Port Ayarları */
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.BaudRate = 9600;
                    serialPort1.Parity = Parity.None;
                    serialPort1.DataBits = 8;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.Open(); //Seri portu aç
                    /* ------------------ */

                    connection_lbl.Text = "Connection Established";
                    connection_lbl.ForeColor = Color.Green;
                    connection_btn.Text = "DISCONNECT";                 //Buton1 yazısını değiştir
                }

                else
                {
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    connection_lbl.Text = "Disconnected";
                    connection_lbl.ForeColor = Color.Red;
                    connection_btn.Text = "CONNECT";              //Buton1 yazısını değiştir
                    serialPort1.Close();                 //Seri portu kapa
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");      //Hata mesajı
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
            in_data = serialPort1.ReadLine();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
            this.BeginInvoke(new EventHandler(ProcessData));
        }
        private void ProcessData(object sender, EventArgs e)
        {
            label1.Text = in_data;
            s = label1.Text + "," + "," + "," + "," + "," + "";
            splitted_data = s.Split(',');
            if (splitted_data[0] != "*")
            {
                txtKeypad.Text += splitted_data[0];
                if (txtKeypad.TextLength == 4)
                {

                    MessageBox.Show("Password Detected");
                    if (MessageBox.Show("Do you accept the password?", " ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        btnOpen.Enabled = true;
                        btnClose.Enabled = true;
                        txtKeypad.ResetText();
                    }
                    else
                    {

                        txtKeypad.ResetText();
                    }

                }
            }
        }
        private string in_data = "";
        private string[] splitted_data;
        private int ldrValue;
        private string s ;


        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTemp.Text = splitted_data[1];
            txtMoisture.Text = splitted_data[2];
            Int32.TryParse(splitted_data[3], out ldrValue);
            if (ldrValue > 820)
            {
                timer1.Enabled = false;
                MessageBox.Show("Light level is low!", "Information..", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (MessageBox.Show("Does the light turn on?", "Information..", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    serialPort1.WriteLine("e");
                    groupBox2.Enabled = true;
                    groupBox2.BackColor = Color.Green;
                    timer1.Enabled = true;
            }

            label1.Text = "";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (splitted_data[4] == "1")
            {
                SmtpClient SmtpServer = new SmtpClient();
                SmtpServer.Credentials = new NetworkCredential("ortunarguvenlik@gmail.com", "140207009");  //buraya kendi gmail adresinizi ve şifrenizi girin
                SmtpServer.Port = 587;                              //Port Numarası
                SmtpServer.Host = "smtp.gmail.com";                 //Sunucu adresi
                SmtpServer.EnableSsl = true;                        //SSL ayarı
                MailMessage mail = new MailMessage();
                mail.To.Add("aralesinkou@gmail.com");            //Gönderilecek adres
                mail.From = new MailAddress("aralesinkou@gmail.com", "ORTUNAR Security");  //Mailin gönderildiği adres ve isim tanımlaması
                mail.Subject = "Motion Detected!";     //Mail konusu
                mail.Body = "Motion Detected at Home!";//Mailin body kısmındaki metin
                SmtpServer.Send(mail);  //Maili gönder
                System.Threading.Thread.Sleep(2000);  //2 saniye bekleme süresi
                MessageBox.Show("ALARM ON!", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MessageBox.Show("ALARM ON!!!");
                alarmOFF.Enabled = true;
                alarmON.Enabled = true;
                panel1.BackColor = Color.Red;
                timer2.Enabled = false;
                pictureBox3.Visible = true;
            }
        }

        private void alarmON_Click(object sender, EventArgs e)
        {
            serialPort1.Write("y");
        }

        private void alarmOFF_Click(object sender, EventArgs e)
        {
            serialPort1.Write("x");
            panel1.BackColor = Color.LightGray;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            serialPort1.Write("a");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            serialPort1.Write("b");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (serialPort1.IsOpen) serialPort1.Close();    //Seri port açıksa kapat
            timer1.Enabled = false;
            timer2.Enabled = false;

        }

        private void rbFanClose_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFanClose.Checked) serialPort1.Write("p");
        }

        private void rbFanLow_CheckedChanged(object sender, EventArgs e)
        {
           if(rbFanLow.Checked) serialPort1.Write("r");
        }

        private void rbFanMid_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFanMid.Checked) serialPort1.Write("t");
        }

        private void rbFanHigh_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFanHigh.Checked) serialPort1.Write("u");
        }

        private void rbLightClose_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLightClose.Checked) serialPort1.Write("g");
        }

        private void rbLightLow_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLightLow.Checked) serialPort1.Write("f");
        }

        private void rbLightMid_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLightMid.Checked) serialPort1.Write("e");
        }

        private void rbLightHigh_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLightHigh.Checked) serialPort1.Write("d");
        }
    }
}

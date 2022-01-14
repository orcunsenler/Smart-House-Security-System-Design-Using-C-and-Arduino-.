namespace smart_home_security_system
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.connection_lbl = new System.Windows.Forms.Label();
            this.connection_btn = new System.Windows.Forms.Button();
            this.txtKeypad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.alarmON = new System.Windows.Forms.Button();
            this.alarmOFF = new System.Windows.Forms.Button();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtMoisture = new System.Windows.Forms.TextBox();
            this.rbFanClose = new System.Windows.Forms.RadioButton();
            this.rbFanLow = new System.Windows.Forms.RadioButton();
            this.rbFanMid = new System.Windows.Forms.RadioButton();
            this.rbFanHigh = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rbLightClose = new System.Windows.Forms.RadioButton();
            this.rbLightHigh = new System.Windows.Forms.RadioButton();
            this.rbLightLow = new System.Windows.Forms.RadioButton();
            this.rbLightMid = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(39, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "OrTunAr Security";
            // 
            // connection_lbl
            // 
            this.connection_lbl.AutoSize = true;
            this.connection_lbl.Location = new System.Drawing.Point(36, 70);
            this.connection_lbl.Name = "connection_lbl";
            this.connection_lbl.Size = new System.Drawing.Size(0, 13);
            this.connection_lbl.TabIndex = 1;
            // 
            // connection_btn
            // 
            this.connection_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connection_btn.Location = new System.Drawing.Point(188, 37);
            this.connection_btn.Name = "connection_btn";
            this.connection_btn.Size = new System.Drawing.Size(152, 23);
            this.connection_btn.TabIndex = 2;
            this.connection_btn.Text = "CONNECT";
            this.connection_btn.UseVisualStyleBackColor = true;
            this.connection_btn.Click += new System.EventHandler(this.connection_btn_Click);
            // 
            // txtKeypad
            // 
            this.txtKeypad.Location = new System.Drawing.Point(39, 119);
            this.txtKeypad.Name = "txtKeypad";
            this.txtKeypad.Size = new System.Drawing.Size(121, 20);
            this.txtKeypad.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(63, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // btnOpen
            // 
            this.btnOpen.Enabled = false;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(188, 117);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 38);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "Open The Door";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Enabled = false;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(269, 117);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(71, 39);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close The Door";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // alarmON
            // 
            this.alarmON.BackColor = System.Drawing.Color.Transparent;
            this.alarmON.Enabled = false;
            this.alarmON.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmON.Location = new System.Drawing.Point(16, 96);
            this.alarmON.Name = "alarmON";
            this.alarmON.Size = new System.Drawing.Size(82, 60);
            this.alarmON.TabIndex = 7;
            this.alarmON.Text = "Turn on the Lights and the Alarm";
            this.alarmON.UseVisualStyleBackColor = false;
            this.alarmON.Click += new System.EventHandler(this.alarmON_Click);
            // 
            // alarmOFF
            // 
            this.alarmOFF.BackColor = System.Drawing.Color.Transparent;
            this.alarmOFF.Enabled = false;
            this.alarmOFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmOFF.Location = new System.Drawing.Point(104, 96);
            this.alarmOFF.Name = "alarmOFF";
            this.alarmOFF.Size = new System.Drawing.Size(80, 60);
            this.alarmOFF.TabIndex = 8;
            this.alarmOFF.Text = "Turn Off the Lights and the Alarm";
            this.alarmOFF.UseVisualStyleBackColor = false;
            this.alarmOFF.Click += new System.EventHandler(this.alarmOFF_Click);
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(425, 70);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(100, 20);
            this.txtTemp.TabIndex = 17;
            // 
            // txtMoisture
            // 
            this.txtMoisture.Location = new System.Drawing.Point(561, 70);
            this.txtMoisture.Name = "txtMoisture";
            this.txtMoisture.Size = new System.Drawing.Size(100, 20);
            this.txtMoisture.TabIndex = 18;
            // 
            // rbFanClose
            // 
            this.rbFanClose.AutoSize = true;
            this.rbFanClose.Location = new System.Drawing.Point(15, 19);
            this.rbFanClose.Name = "rbFanClose";
            this.rbFanClose.Size = new System.Drawing.Size(56, 19);
            this.rbFanClose.TabIndex = 19;
            this.rbFanClose.TabStop = true;
            this.rbFanClose.Text = "Close";
            this.rbFanClose.UseVisualStyleBackColor = true;
            this.rbFanClose.CheckedChanged += new System.EventHandler(this.rbFanClose_CheckedChanged);
            // 
            // rbFanLow
            // 
            this.rbFanLow.AutoSize = true;
            this.rbFanLow.Location = new System.Drawing.Point(15, 41);
            this.rbFanLow.Name = "rbFanLow";
            this.rbFanLow.Size = new System.Drawing.Size(48, 19);
            this.rbFanLow.TabIndex = 20;
            this.rbFanLow.TabStop = true;
            this.rbFanLow.Text = "Low";
            this.rbFanLow.UseVisualStyleBackColor = true;
            this.rbFanLow.CheckedChanged += new System.EventHandler(this.rbFanLow_CheckedChanged);
            // 
            // rbFanMid
            // 
            this.rbFanMid.AutoSize = true;
            this.rbFanMid.Location = new System.Drawing.Point(15, 64);
            this.rbFanMid.Name = "rbFanMid";
            this.rbFanMid.Size = new System.Drawing.Size(63, 19);
            this.rbFanMid.TabIndex = 21;
            this.rbFanMid.TabStop = true;
            this.rbFanMid.Text = "Middle";
            this.rbFanMid.UseVisualStyleBackColor = true;
            this.rbFanMid.CheckedChanged += new System.EventHandler(this.rbFanMid_CheckedChanged);
            // 
            // rbFanHigh
            // 
            this.rbFanHigh.AutoSize = true;
            this.rbFanHigh.Location = new System.Drawing.Point(15, 87);
            this.rbFanHigh.Name = "rbFanHigh";
            this.rbFanHigh.Size = new System.Drawing.Size(51, 19);
            this.rbFanHigh.TabIndex = 22;
            this.rbFanHigh.TabStop = true;
            this.rbFanHigh.Text = "High";
            this.rbFanHigh.UseVisualStyleBackColor = true;
            this.rbFanHigh.CheckedChanged += new System.EventHandler(this.rbFanHigh_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.rbFanClose);
            this.groupBox1.Controls.Add(this.rbFanHigh);
            this.groupBox1.Controls.Add(this.rbFanLow);
            this.groupBox1.Controls.Add(this.rbFanMid);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 119);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fan";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(87, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(423, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Temperature (°C)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(558, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Moisture (%)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.rbLightClose);
            this.groupBox2.Controls.Add(this.rbLightHigh);
            this.groupBox2.Controls.Add(this.rbLightLow);
            this.groupBox2.Controls.Add(this.rbLightMid);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(248, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 119);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Light";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(85, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // rbLightClose
            // 
            this.rbLightClose.AutoSize = true;
            this.rbLightClose.Location = new System.Drawing.Point(15, 19);
            this.rbLightClose.Name = "rbLightClose";
            this.rbLightClose.Size = new System.Drawing.Size(68, 19);
            this.rbLightClose.TabIndex = 19;
            this.rbLightClose.TabStop = true;
            this.rbLightClose.Text = "Turn Off";
            this.rbLightClose.UseVisualStyleBackColor = true;
            this.rbLightClose.CheckedChanged += new System.EventHandler(this.rbLightClose_CheckedChanged);
            // 
            // rbLightHigh
            // 
            this.rbLightHigh.AutoSize = true;
            this.rbLightHigh.Location = new System.Drawing.Point(15, 87);
            this.rbLightHigh.Name = "rbLightHigh";
            this.rbLightHigh.Size = new System.Drawing.Size(51, 19);
            this.rbLightHigh.TabIndex = 22;
            this.rbLightHigh.TabStop = true;
            this.rbLightHigh.Text = "High";
            this.rbLightHigh.UseVisualStyleBackColor = true;
            this.rbLightHigh.CheckedChanged += new System.EventHandler(this.rbLightHigh_CheckedChanged);
            // 
            // rbLightLow
            // 
            this.rbLightLow.AutoSize = true;
            this.rbLightLow.Location = new System.Drawing.Point(15, 41);
            this.rbLightLow.Name = "rbLightLow";
            this.rbLightLow.Size = new System.Drawing.Size(48, 19);
            this.rbLightLow.TabIndex = 20;
            this.rbLightLow.TabStop = true;
            this.rbLightLow.Text = "Low";
            this.rbLightLow.UseVisualStyleBackColor = true;
            this.rbLightLow.CheckedChanged += new System.EventHandler(this.rbLightLow_CheckedChanged);
            // 
            // rbLightMid
            // 
            this.rbLightMid.AutoSize = true;
            this.rbLightMid.Location = new System.Drawing.Point(15, 64);
            this.rbLightMid.Name = "rbLightMid";
            this.rbLightMid.Size = new System.Drawing.Size(63, 19);
            this.rbLightMid.TabIndex = 21;
            this.rbLightMid.TabStop = true;
            this.rbLightMid.Text = "Middle";
            this.rbLightMid.UseVisualStyleBackColor = true;
            this.rbLightMid.CheckedChanged += new System.EventHandler(this.rbLightMid_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.alarmON);
            this.panel1.Controls.Add(this.alarmOFF);
            this.panel1.Location = new System.Drawing.Point(461, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 159);
            this.panel1.TabIndex = 27;
          
            // 
            // pictureBox3
            // 
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(46, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(107, 85);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(713, 347);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMoisture);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKeypad);
            this.Controls.Add(this.connection_btn);
            this.Controls.Add(this.connection_lbl);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label connection_lbl;
        private System.Windows.Forms.Button connection_btn;
        private System.Windows.Forms.TextBox txtKeypad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button alarmON;
        private System.Windows.Forms.Button alarmOFF;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtMoisture;
        private System.Windows.Forms.RadioButton rbFanClose;
        private System.Windows.Forms.RadioButton rbFanLow;
        private System.Windows.Forms.RadioButton rbFanMid;
        private System.Windows.Forms.RadioButton rbFanHigh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbLightClose;
        private System.Windows.Forms.RadioButton rbLightHigh;
        private System.Windows.Forms.RadioButton rbLightLow;
        private System.Windows.Forms.RadioButton rbLightMid;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
    }
}


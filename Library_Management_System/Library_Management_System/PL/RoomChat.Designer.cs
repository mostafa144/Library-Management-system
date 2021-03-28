
namespace Library_Management_System.PL
{
    partial class RoomChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomChat));
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelLocalIp = new System.Windows.Forms.Label();
            this.textRemotePort = new System.Windows.Forms.TextBox();
            this.textRemoteIP = new System.Windows.Forms.TextBox();
            this.textLocalIp = new System.Windows.Forms.TextBox();
            this.labelLocalPort = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textLocalPort = new System.Windows.Forms.TextBox();
            this.labelRemoteIP = new System.Windows.Forms.Label();
            this.labelRemotePort = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMessage2 = new System.Windows.Forms.TextBox();
            this.txtScreen = new System.Windows.Forms.ListBox();
            this.txtMessage = new System.Windows.Forms.ListBox();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.btnSend2 = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSend
            // 
            this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.Location = new System.Drawing.Point(749, 607);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(102, 27);
            this.buttonSend.TabIndex = 24;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // labelLocalIp
            // 
            this.labelLocalIp.AutoSize = true;
            this.labelLocalIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocalIp.Location = new System.Drawing.Point(4, 27);
            this.labelLocalIp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLocalIp.Name = "labelLocalIp";
            this.labelLocalIp.Size = new System.Drawing.Size(36, 20);
            this.labelLocalIp.TabIndex = 2;
            this.labelLocalIp.Text = "IP :";
            // 
            // textRemotePort
            // 
            this.textRemotePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRemotePort.Location = new System.Drawing.Point(91, 81);
            this.textRemotePort.Margin = new System.Windows.Forms.Padding(2);
            this.textRemotePort.Name = "textRemotePort";
            this.textRemotePort.Size = new System.Drawing.Size(133, 26);
            this.textRemotePort.TabIndex = 7;
            this.textRemotePort.TextChanged += new System.EventHandler(this.textRemotePort_TextChanged);
            // 
            // textRemoteIP
            // 
            this.textRemoteIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRemoteIP.Location = new System.Drawing.Point(92, 27);
            this.textRemoteIP.Margin = new System.Windows.Forms.Padding(2);
            this.textRemoteIP.Name = "textRemoteIP";
            this.textRemoteIP.Size = new System.Drawing.Size(132, 26);
            this.textRemoteIP.TabIndex = 6;
            // 
            // textLocalIp
            // 
            this.textLocalIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLocalIp.Location = new System.Drawing.Point(83, 27);
            this.textLocalIp.Margin = new System.Windows.Forms.Padding(2);
            this.textLocalIp.Name = "textLocalIp";
            this.textLocalIp.Size = new System.Drawing.Size(141, 26);
            this.textLocalIp.TabIndex = 1;
            // 
            // labelLocalPort
            // 
            this.labelLocalPort.AutoSize = true;
            this.labelLocalPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocalPort.Location = new System.Drawing.Point(4, 84);
            this.labelLocalPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLocalPort.Name = "labelLocalPort";
            this.labelLocalPort.Size = new System.Drawing.Size(52, 20);
            this.labelLocalPort.TabIndex = 3;
            this.labelLocalPort.Text = "Port :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textLocalIp);
            this.groupBox1.Controls.Add(this.textLocalPort);
            this.groupBox1.Controls.Add(this.labelLocalPort);
            this.groupBox1.Controls.Add(this.labelLocalIp);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(344, 85);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(274, 118);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // textLocalPort
            // 
            this.textLocalPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLocalPort.Location = new System.Drawing.Point(83, 78);
            this.textLocalPort.Margin = new System.Windows.Forms.Padding(2);
            this.textLocalPort.Name = "textLocalPort";
            this.textLocalPort.Size = new System.Drawing.Size(141, 26);
            this.textLocalPort.TabIndex = 2;
            // 
            // labelRemoteIP
            // 
            this.labelRemoteIP.AutoSize = true;
            this.labelRemoteIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemoteIP.Location = new System.Drawing.Point(10, 26);
            this.labelRemoteIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRemoteIP.Name = "labelRemoteIP";
            this.labelRemoteIP.Size = new System.Drawing.Size(36, 20);
            this.labelRemoteIP.TabIndex = 5;
            this.labelRemoteIP.Text = "IP :";
            // 
            // labelRemotePort
            // 
            this.labelRemotePort.AutoSize = true;
            this.labelRemotePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemotePort.Location = new System.Drawing.Point(10, 84);
            this.labelRemotePort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRemotePort.Name = "labelRemotePort";
            this.labelRemotePort.Size = new System.Drawing.Size(52, 20);
            this.labelRemotePort.TabIndex = 4;
            this.labelRemotePort.Text = "Port :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textRemotePort);
            this.groupBox2.Controls.Add(this.textRemoteIP);
            this.groupBox2.Controls.Add(this.labelRemoteIP);
            this.groupBox2.Controls.Add(this.labelRemotePort);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(663, 85);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(263, 118);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // txtMessage2
            // 
            this.txtMessage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage2.Location = new System.Drawing.Point(344, 572);
            this.txtMessage2.Margin = new System.Windows.Forms.Padding(2);
            this.txtMessage2.Name = "txtMessage2";
            this.txtMessage2.Size = new System.Drawing.Size(276, 26);
            this.txtMessage2.TabIndex = 31;
            // 
            // txtScreen
            // 
            this.txtScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScreen.FormattingEnabled = true;
            this.txtScreen.ItemHeight = 20;
            this.txtScreen.Location = new System.Drawing.Point(665, 315);
            this.txtScreen.Margin = new System.Windows.Forms.Padding(2);
            this.txtScreen.Name = "txtScreen";
            this.txtScreen.Size = new System.Drawing.Size(276, 244);
            this.txtScreen.TabIndex = 30;
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.FormattingEnabled = true;
            this.txtMessage.ItemHeight = 20;
            this.txtMessage.Location = new System.Drawing.Point(344, 313);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(2);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(276, 244);
            this.txtMessage.TabIndex = 29;
            // 
            // textMessage
            // 
            this.textMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMessage.Location = new System.Drawing.Point(665, 572);
            this.textMessage.Margin = new System.Windows.Forms.Padding(2);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(276, 26);
            this.textMessage.TabIndex = 22;
            // 
            // btnSend2
            // 
            this.btnSend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend2.Location = new System.Drawing.Point(427, 607);
            this.btnSend2.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend2.Name = "btnSend2";
            this.btnSend2.Size = new System.Drawing.Size(97, 27);
            this.btnSend2.TabIndex = 32;
            this.btnSend2.Text = "Send";
            this.btnSend2.UseVisualStyleBackColor = true;
            this.btnSend2.Click += new System.EventHandler(this.btnSend2_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.Location = new System.Drawing.Point(529, 225);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(218, 37);
            this.buttonConnect.TabIndex = 25;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(409, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Mostafa Chat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(745, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "AbdUllah Chat";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(1127, 655);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 54);
            this.button3.TabIndex = 35;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Freestyle Script", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(415, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(455, 76);
            this.label7.TabIndex = 36;
            this.label7.Text = "Now you can chat friends";
            // 
            // RoomChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1303, 721);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtMessage2);
            this.Controls.Add(this.txtScreen);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.btnSend2);
            this.Controls.Add(this.buttonConnect);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RoomChat";
            this.Text = "RoomChat";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RoomChat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelLocalIp;
        private System.Windows.Forms.TextBox textRemotePort;
        private System.Windows.Forms.TextBox textRemoteIP;
        private System.Windows.Forms.TextBox textLocalIp;
        private System.Windows.Forms.Label labelLocalPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textLocalPort;
        private System.Windows.Forms.Label labelRemoteIP;
        private System.Windows.Forms.Label labelRemotePort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMessage2;
        private System.Windows.Forms.ListBox txtScreen;
        private System.Windows.Forms.ListBox txtMessage;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Button btnSend2;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
    }
}

namespace Library_Mangement_system.PL
{
    partial class ChatRoom
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
            this.buttonSend = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textLocalIp = new System.Windows.Forms.TextBox();
            this.textLocalPort = new System.Windows.Forms.TextBox();
            this.textRemoteIP = new System.Windows.Forms.TextBox();
            this.txtMessage2 = new System.Windows.Forms.TextBox();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.txtScreen = new System.Windows.Forms.ListBox();
            this.txtMessage = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textRemotePort = new System.Windows.Forms.TextBox();
            this.ofmostafa = new System.Windows.Forms.RadioButton();
            this.onMostafa = new System.Windows.Forms.RadioButton();
            this.onAbdo = new System.Windows.Forms.RadioButton();
            this.ofAbdo = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSend
            // 
            this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.Location = new System.Drawing.Point(993, 497);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(106, 33);
            this.buttonSend.TabIndex = 0;
            this.buttonSend.Text = "send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(441, 493);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "send2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.Location = new System.Drawing.Point(488, 184);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(212, 39);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textLocalIp
            // 
            this.textLocalIp.Location = new System.Drawing.Point(103, 21);
            this.textLocalIp.Name = "textLocalIp";
            this.textLocalIp.Size = new System.Drawing.Size(139, 22);
            this.textLocalIp.TabIndex = 3;
            // 
            // textLocalPort
            // 
            this.textLocalPort.Location = new System.Drawing.Point(103, 62);
            this.textLocalPort.Name = "textLocalPort";
            this.textLocalPort.Size = new System.Drawing.Size(139, 22);
            this.textLocalPort.TabIndex = 4;
            // 
            // textRemoteIP
            // 
            this.textRemoteIP.Location = new System.Drawing.Point(74, 32);
            this.textRemoteIP.Name = "textRemoteIP";
            this.textRemoteIP.Size = new System.Drawing.Size(162, 22);
            this.textRemoteIP.TabIndex = 5;
            // 
            // txtMessage2
            // 
            this.txtMessage2.Location = new System.Drawing.Point(55, 497);
            this.txtMessage2.Name = "txtMessage2";
            this.txtMessage2.Size = new System.Drawing.Size(367, 22);
            this.txtMessage2.TabIndex = 6;
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(620, 497);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(350, 22);
            this.textMessage.TabIndex = 7;
            // 
            // txtScreen
            // 
            this.txtScreen.FormattingEnabled = true;
            this.txtScreen.ItemHeight = 16;
            this.txtScreen.Location = new System.Drawing.Point(620, 251);
            this.txtScreen.Name = "txtScreen";
            this.txtScreen.Size = new System.Drawing.Size(479, 228);
            this.txtScreen.TabIndex = 8;
            // 
            // txtMessage
            // 
            this.txtMessage.FormattingEnabled = true;
            this.txtMessage.ItemHeight = 16;
            this.txtMessage.Location = new System.Drawing.Point(55, 251);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(474, 228);
            this.txtMessage.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.IP);
            this.groupBox1.Controls.Add(this.textLocalPort);
            this.groupBox1.Controls.Add(this.textLocalIp);
            this.groupBox1.Location = new System.Drawing.Point(71, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textRemotePort);
            this.groupBox2.Controls.Add(this.textRemoteIP);
            this.groupBox2.Location = new System.Drawing.Point(779, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // IP
            // 
            this.IP.AutoSize = true;
            this.IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IP.Location = new System.Drawing.Point(17, 21);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(28, 24);
            this.IP.TabIndex = 5;
            this.IP.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(774, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Abdullah Chat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mostafa Chat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "IP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Port";
            // 
            // textRemotePort
            // 
            this.textRemotePort.Location = new System.Drawing.Point(74, 62);
            this.textRemotePort.Name = "textRemotePort";
            this.textRemotePort.Size = new System.Drawing.Size(162, 22);
            this.textRemotePort.TabIndex = 11;
            // 
            // ofmostafa
            // 
            this.ofmostafa.AutoSize = true;
            this.ofmostafa.Location = new System.Drawing.Point(251, 184);
            this.ofmostafa.Name = "ofmostafa";
            this.ofmostafa.Size = new System.Drawing.Size(79, 21);
            this.ofmostafa.TabIndex = 11;
            this.ofmostafa.TabStop = true;
            this.ofmostafa.Text = "Off Line";
            this.ofmostafa.UseVisualStyleBackColor = true;
            // 
            // onMostafa
            // 
            this.onMostafa.AutoSize = true;
            this.onMostafa.Location = new System.Drawing.Point(251, 224);
            this.onMostafa.Name = "onMostafa";
            this.onMostafa.Size = new System.Drawing.Size(70, 21);
            this.onMostafa.TabIndex = 12;
            this.onMostafa.TabStop = true;
            this.onMostafa.Text = "Online";
            this.onMostafa.UseVisualStyleBackColor = true;
            // 
            // onAbdo
            // 
            this.onAbdo.AutoSize = true;
            this.onAbdo.Location = new System.Drawing.Point(989, 224);
            this.onAbdo.Name = "onAbdo";
            this.onAbdo.Size = new System.Drawing.Size(70, 21);
            this.onAbdo.TabIndex = 13;
            this.onAbdo.TabStop = true;
            this.onAbdo.Text = "Online";
            this.onAbdo.UseVisualStyleBackColor = true;
            // 
            // ofAbdo
            // 
            this.ofAbdo.AutoSize = true;
            this.ofAbdo.Location = new System.Drawing.Point(989, 187);
            this.ofAbdo.Name = "ofAbdo";
            this.ofAbdo.Size = new System.Drawing.Size(79, 21);
            this.ofAbdo.TabIndex = 14;
            this.ofAbdo.TabStop = true;
            this.ofAbdo.Text = "Off Line";
            this.ofAbdo.UseVisualStyleBackColor = true;
            // 
            // ChatRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1161, 584);
            this.Controls.Add(this.ofAbdo);
            this.Controls.Add(this.onAbdo);
            this.Controls.Add(this.onMostafa);
            this.Controls.Add(this.ofmostafa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtScreen);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.txtMessage2);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonSend);
            this.Name = "ChatRoom";
            this.Text = "ChatRoom";
            this.Load += new System.EventHandler(this.ChatRoom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textLocalIp;
        private System.Windows.Forms.TextBox textLocalPort;
        private System.Windows.Forms.TextBox textRemoteIP;
        private System.Windows.Forms.TextBox txtMessage2;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.ListBox txtScreen;
        private System.Windows.Forms.ListBox txtMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textRemotePort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton ofmostafa;
        private System.Windows.Forms.RadioButton onMostafa;
        private System.Windows.Forms.RadioButton onAbdo;
        private System.Windows.Forms.RadioButton ofAbdo;
    }
}
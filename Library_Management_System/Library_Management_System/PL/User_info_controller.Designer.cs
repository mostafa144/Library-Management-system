namespace Library_Management_System
{
    partial class User_info_controller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_info_controller));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.TextBox();
            this.user_address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.user_phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.user_ssn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.create_acc = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(512, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Change Password ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(459, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name :";
            // 
            // user_name
            // 
            this.user_name.Enabled = false;
            this.user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.Location = new System.Drawing.Point(668, 184);
            this.user_name.Name = "user_name";
            this.user_name.ReadOnly = true;
            this.user_name.Size = new System.Drawing.Size(311, 38);
            this.user_name.TabIndex = 2;
            // 
            // user_address
            // 
            this.user_address.Enabled = false;
            this.user_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_address.Location = new System.Drawing.Point(668, 245);
            this.user_address.Name = "user_address";
            this.user_address.ReadOnly = true;
            this.user_address.Size = new System.Drawing.Size(311, 38);
            this.user_address.TabIndex = 4;
            this.user_address.TextChanged += new System.EventHandler(this.user_address_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(459, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address :";
            // 
            // user_phone
            // 
            this.user_phone.Enabled = false;
            this.user_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_phone.Location = new System.Drawing.Point(668, 311);
            this.user_phone.Name = "user_phone";
            this.user_phone.ReadOnly = true;
            this.user_phone.Size = new System.Drawing.Size(311, 38);
            this.user_phone.TabIndex = 6;
            this.user_phone.TextChanged += new System.EventHandler(this.user_phone_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(459, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone :";
            // 
            // user_ssn
            // 
            this.user_ssn.Enabled = false;
            this.user_ssn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_ssn.Location = new System.Drawing.Point(668, 379);
            this.user_ssn.Name = "user_ssn";
            this.user_ssn.ReadOnly = true;
            this.user_ssn.Size = new System.Drawing.Size(311, 38);
            this.user_ssn.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(459, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "National id :";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(782, 493);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 41);
            this.button2.TabIndex = 9;
            this.button2.Text = "Change Information ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(399, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(661, 69);
            this.label5.TabIndex = 10;
            this.label5.Text = "Account Information";
            // 
            // create_acc
            // 
            this.create_acc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_acc.Location = new System.Drawing.Point(651, 569);
            this.create_acc.Name = "create_acc";
            this.create_acc.Size = new System.Drawing.Size(197, 41);
            this.create_acc.TabIndex = 11;
            this.create_acc.Text = "Create New Account";
            this.create_acc.UseVisualStyleBackColor = true;
            this.create_acc.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(1161, 688);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 52);
            this.button4.TabIndex = 16;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // User_info_controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1315, 742);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.create_acc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.user_ssn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.user_phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.user_address);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "User_info_controller";
            this.Text = "User_info_controller";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.User_info_controller_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.TextBox user_address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user_phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user_ssn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button create_acc;
        private System.Windows.Forms.Button button4;
    }
}
namespace Library_Management_System
{
    partial class Update_user_pass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_user_pass));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.user_old_pass = new System.Windows.Forms.TextBox();
            this.user_new_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.user_new_pass_re = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(626, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Password :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // user_old_pass
            // 
            this.user_old_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_old_pass.Location = new System.Drawing.Point(566, 242);
            this.user_old_pass.Name = "user_old_pass";
            this.user_old_pass.Size = new System.Drawing.Size(253, 24);
            this.user_old_pass.TabIndex = 2;
            // 
            // user_new_pass
            // 
            this.user_new_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_new_pass.Location = new System.Drawing.Point(566, 300);
            this.user_new_pass.Name = "user_new_pass";
            this.user_new_pass.Size = new System.Drawing.Size(253, 24);
            this.user_new_pass.TabIndex = 4;
            this.user_new_pass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(341, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Password :";
            // 
            // user_new_pass_re
            // 
            this.user_new_pass_re.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_new_pass_re.Location = new System.Drawing.Point(566, 362);
            this.user_new_pass_re.Name = "user_new_pass_re";
            this.user_new_pass_re.Size = new System.Drawing.Size(253, 24);
            this.user_new_pass_re.TabIndex = 6;
            this.user_new_pass_re.TextChanged += new System.EventHandler(this.user_new_pass_re_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(341, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Re-type  Password :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Freestyle Script", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(242, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(790, 76);
            this.label7.TabIndex = 23;
            this.label7.Text = "Here you can update your personal information";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(1133, 544);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 40);
            this.button3.TabIndex = 24;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Update_user_pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1303, 596);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.user_new_pass_re);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.user_new_pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.user_old_pass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Update_user_pass";
            this.Text = "Update_user_pass";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox user_old_pass;
        private System.Windows.Forms.TextBox user_new_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user_new_pass_re;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
    }
}
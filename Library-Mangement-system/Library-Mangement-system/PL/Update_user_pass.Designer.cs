
namespace Library_Mangement_system.PL
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
            this.user_old_pass = new System.Windows.Forms.TextBox();
            this.user_new_pass = new System.Windows.Forms.TextBox();
            this.user_new_pass_re = new System.Windows.Forms.TextBox();
            this.labelCurrentPass = new System.Windows.Forms.Label();
            this.labelNewPass = new System.Windows.Forms.Label();
            this.labelRetyePass = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_old_pass
            // 
            this.user_old_pass.Location = new System.Drawing.Point(338, 119);
            this.user_old_pass.Name = "user_old_pass";
            this.user_old_pass.Size = new System.Drawing.Size(257, 22);
            this.user_old_pass.TabIndex = 0;
            // 
            // user_new_pass
            // 
            this.user_new_pass.Location = new System.Drawing.Point(338, 207);
            this.user_new_pass.Name = "user_new_pass";
            this.user_new_pass.Size = new System.Drawing.Size(257, 22);
            this.user_new_pass.TabIndex = 1;
            // 
            // user_new_pass_re
            // 
            this.user_new_pass_re.Location = new System.Drawing.Point(338, 288);
            this.user_new_pass_re.Name = "user_new_pass_re";
            this.user_new_pass_re.Size = new System.Drawing.Size(257, 22);
            this.user_new_pass_re.TabIndex = 2;
            // 
            // labelCurrentPass
            // 
            this.labelCurrentPass.AutoSize = true;
            this.labelCurrentPass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentPass.Location = new System.Drawing.Point(75, 119);
            this.labelCurrentPass.Name = "labelCurrentPass";
            this.labelCurrentPass.Size = new System.Drawing.Size(209, 24);
            this.labelCurrentPass.TabIndex = 3;
            this.labelCurrentPass.Text = "Current Password : ";
            // 
            // labelNewPass
            // 
            this.labelNewPass.AutoSize = true;
            this.labelNewPass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPass.Location = new System.Drawing.Point(75, 203);
            this.labelNewPass.Name = "labelNewPass";
            this.labelNewPass.Size = new System.Drawing.Size(171, 24);
            this.labelNewPass.TabIndex = 4;
            this.labelNewPass.Text = "New Password :";
            // 
            // labelRetyePass
            // 
            this.labelRetyePass.AutoSize = true;
            this.labelRetyePass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRetyePass.Location = new System.Drawing.Point(75, 288);
            this.labelRetyePass.Name = "labelRetyePass";
            this.labelRetyePass.Size = new System.Drawing.Size(208, 24);
            this.labelRetyePass.TabIndex = 5;
            this.labelRetyePass.Text = "ReType Password : ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(394, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.btnChange_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.btnChange_MouseHover);
            // 
            // Update_user_pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelRetyePass);
            this.Controls.Add(this.labelNewPass);
            this.Controls.Add(this.labelCurrentPass);
            this.Controls.Add(this.user_new_pass_re);
            this.Controls.Add(this.user_new_pass);
            this.Controls.Add(this.user_old_pass);
            this.Name = "Update_user_pass";
            this.Text = "Update_user_pass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user_old_pass;
        private System.Windows.Forms.TextBox user_new_pass;
        private System.Windows.Forms.TextBox user_new_pass_re;
        private System.Windows.Forms.Label labelCurrentPass;
        private System.Windows.Forms.Label labelNewPass;
        private System.Windows.Forms.Label labelRetyePass;
        private System.Windows.Forms.Button button1;
    }
}
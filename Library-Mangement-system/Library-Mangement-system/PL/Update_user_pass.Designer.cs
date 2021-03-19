
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelCurrentPass = new System.Windows.Forms.Label();
            this.labelNewPass = new System.Windows.Forms.Label();
            this.labelRetyePass = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(296, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 24);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(296, 207);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 24);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(296, 288);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(225, 24);
            this.textBox3.TabIndex = 2;
            // 
            // labelCurrentPass
            // 
            this.labelCurrentPass.AutoSize = true;
            this.labelCurrentPass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentPass.Location = new System.Drawing.Point(66, 119);
            this.labelCurrentPass.Name = "labelCurrentPass";
            this.labelCurrentPass.Size = new System.Drawing.Size(209, 24);
            this.labelCurrentPass.TabIndex = 3;
            this.labelCurrentPass.Text = "Current Password : ";
            // 
            // labelNewPass
            // 
            this.labelNewPass.AutoSize = true;
            this.labelNewPass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPass.Location = new System.Drawing.Point(66, 203);
            this.labelNewPass.Name = "labelNewPass";
            this.labelNewPass.Size = new System.Drawing.Size(171, 24);
            this.labelNewPass.TabIndex = 4;
            this.labelNewPass.Text = "New Password :";
            // 
            // labelRetyePass
            // 
            this.labelRetyePass.AutoSize = true;
            this.labelRetyePass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRetyePass.Location = new System.Drawing.Point(66, 288);
            this.labelRetyePass.Name = "labelRetyePass";
            this.labelRetyePass.Size = new System.Drawing.Size(208, 24);
            this.labelRetyePass.TabIndex = 5;
            this.labelRetyePass.Text = "ReType Password : ";
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(345, 369);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(114, 38);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.MouseLeave += new System.EventHandler(this.btnChange_MouseLeave);
            this.btnChange.MouseHover += new System.EventHandler(this.btnChange_MouseHover);
            // 
            // Update_user_pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.labelRetyePass);
            this.Controls.Add(this.labelNewPass);
            this.Controls.Add(this.labelCurrentPass);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Update_user_pass";
            this.Text = "Update_user_pass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelCurrentPass;
        private System.Windows.Forms.Label labelNewPass;
        private System.Windows.Forms.Label labelRetyePass;
        private System.Windows.Forms.Button btnChange;
    }
}
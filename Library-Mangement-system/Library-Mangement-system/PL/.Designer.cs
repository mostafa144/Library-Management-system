
namespace Library_Mangement_system
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
            this.txtUser_name = new System.Windows.Forms.TextBox();
            this.txtUser_pass = new System.Windows.Forms.TextBox();
            this.txtUser_phone = new System.Windows.Forms.TextBox();
            this.txtUser_address = new System.Windows.Forms.TextBox();
            this.txtUser_ssn = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelNationalID = new System.Windows.Forms.Label();
            this.labelEnterPass = new System.Windows.Forms.Label();
            this.btnUpdateInformation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUser_name
            // 
            this.txtUser_name.Location = new System.Drawing.Point(206, 55);
            this.txtUser_name.Name = "txtUser_name";
            this.txtUser_name.Size = new System.Drawing.Size(214, 24);
            this.txtUser_name.TabIndex = 0;
            // 
            // txtUser_pass
            // 
            this.txtUser_pass.Location = new System.Drawing.Point(224, 427);
            this.txtUser_pass.Name = "txtUser_pass";
            this.txtUser_pass.Size = new System.Drawing.Size(175, 24);
            this.txtUser_pass.TabIndex = 1;
            // 
            // txtUser_phone
            // 
            this.txtUser_phone.Location = new System.Drawing.Point(206, 202);
            this.txtUser_phone.Name = "txtUser_phone";
            this.txtUser_phone.Size = new System.Drawing.Size(214, 24);
            this.txtUser_phone.TabIndex = 2;
            // 
            // txtUser_address
            // 
            this.txtUser_address.Location = new System.Drawing.Point(206, 137);
            this.txtUser_address.Name = "txtUser_address";
            this.txtUser_address.Size = new System.Drawing.Size(214, 24);
            this.txtUser_address.TabIndex = 3;
            // 
            // txtUser_ssn
            // 
            this.txtUser_ssn.Location = new System.Drawing.Point(206, 295);
            this.txtUser_ssn.Name = "txtUser_ssn";
            this.txtUser_ssn.Size = new System.Drawing.Size(214, 24);
            this.txtUser_ssn.TabIndex = 4;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(48, 55);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(139, 24);
            this.labelUserName.TabIndex = 5;
            this.labelUserName.Text = "User Name : ";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(48, 133);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(110, 24);
            this.labelAddress.TabIndex = 6;
            this.labelAddress.Text = "Address : ";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(48, 202);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(92, 24);
            this.labelPhone.TabIndex = 7;
            this.labelPhone.Text = "Phone : ";
            // 
            // labelNationalID
            // 
            this.labelNationalID.AutoSize = true;
            this.labelNationalID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNationalID.Location = new System.Drawing.Point(48, 291);
            this.labelNationalID.Name = "labelNationalID";
            this.labelNationalID.Size = new System.Drawing.Size(138, 24);
            this.labelNationalID.TabIndex = 8;
            this.labelNationalID.Text = "National id : ";
            // 
            // labelEnterPass
            // 
            this.labelEnterPass.AutoSize = true;
            this.labelEnterPass.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterPass.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelEnterPass.Location = new System.Drawing.Point(115, 379);
            this.labelEnterPass.Name = "labelEnterPass";
            this.labelEnterPass.Size = new System.Drawing.Size(450, 23);
            this.labelEnterPass.TabIndex = 9;
            this.labelEnterPass.Text = "Enter The Password to Confirm The Operation";
            // 
            // btnUpdateInformation
            // 
            this.btnUpdateInformation.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInformation.Location = new System.Drawing.Point(197, 480);
            this.btnUpdateInformation.Name = "btnUpdateInformation";
            this.btnUpdateInformation.Size = new System.Drawing.Size(241, 42);
            this.btnUpdateInformation.TabIndex = 10;
            this.btnUpdateInformation.Text = "Update Information";
            this.btnUpdateInformation.UseVisualStyleBackColor = true;
            this.btnUpdateInformation.Click += new System.EventHandler(this.btnUpdateInformation_Click);
            this.btnUpdateInformation.MouseLeave += new System.EventHandler(this.btnUpdateInformation_MouseLeave);
            this.btnUpdateInformation.MouseHover += new System.EventHandler(this.btnUpdateInformation_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 561);
            this.Controls.Add(this.btnUpdateInformation);
            this.Controls.Add(this.labelEnterPass);
            this.Controls.Add(this.labelNationalID);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.txtUser_ssn);
            this.Controls.Add(this.txtUser_address);
            this.Controls.Add(this.txtUser_phone);
            this.Controls.Add(this.txtUser_pass);
            this.Controls.Add(this.txtUser_name);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser_name;
        private System.Windows.Forms.TextBox txtUser_pass;
        private System.Windows.Forms.TextBox txtUser_phone;
        private System.Windows.Forms.TextBox txtUser_address;
        private System.Windows.Forms.TextBox txtUser_ssn;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelNationalID;
        private System.Windows.Forms.Label labelEnterPass;
        private System.Windows.Forms.Button btnUpdateInformation;
    }
}


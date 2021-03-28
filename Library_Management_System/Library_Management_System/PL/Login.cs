using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            lbl1.Text = "Date is : " + DateTime.Now + "                              Powered By : ITI Students (Mostafa, Ali, AbdUllah)";
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            User_Employee f2 = new User_Employee();
            f2.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (name.Text == "Name")
            {
                label5.Visible = true;
                name.Text = "";
                name.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (name.Text == "")
            {
                label5.Visible = false;
                name.Text = "Name";
                name.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (password.Text == "Password")
            {
                label4.Visible = true;
                password.Text = "";
                password.ForeColor = Color.Black;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (BL.table_opration.staff.login_make_sure(name.Text,password.Text))
            { 
                 
                BL.User.user = BL.table_opration.staff.login_get_staff(name.Text, password.Text);
               Menu_control f8 = new Menu_control();
                f8.Show();
                this.Hide();
              
            }
            else
            {
                MessageBox.Show("error in login");
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                label4.Visible = false;
                password.Text = "Password";
                password.ForeColor = Color.Gray;
            }
        }
        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            EventArgs ee = new EventArgs();
            if (e.KeyCode == Keys.Enter)
            button2_Click_1(sender, ee);
        }

        
    }
}

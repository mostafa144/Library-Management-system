using Library_Management_System.PL;
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
    public partial class User_Employee : Form
    {
        public User_Employee()
        {
            InitializeComponent();
            lbl1.Text = "Date is : " + DateTime.Now + "                                                Powered By : ITI Students (Mostafa, Ali, AbdUllah)";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Welcome f1 = new Welcome();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login f5 = new Login();
            f5.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_search f3 = new User_search();
            f3.Show();
            this.Hide();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(26, 32, 40);
        }      

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void User_Employee_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(37, 46, 59);
            button1.BackColor = Color.FromArgb(26, 32, 40);
            button2.BackColor = Color.FromArgb(26, 32, 40);
            button3.BackColor = Color.FromArgb(26, 32, 40);
           // button5.BackColor = Color.FromArgb(26, 32, 40);
            statusStrip1.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //RoomChat frm = new RoomChat();
            //frm.Show();
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //OverallReport frm = new OverallReport();
            //frm.Show();
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(26, 32, 40);
        }
    }
}

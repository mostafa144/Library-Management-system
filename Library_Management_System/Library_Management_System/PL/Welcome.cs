using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Library_Management_System
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            lbl1.Text = "Date is : " + DateTime.Now + "                                Powered By : ITI Students (Mostafa, Ali, AbdUllah)";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Employee f2 = new User_Employee();
            f2.Show();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Text = "Go";
            button1.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Text = "Start";
            button1.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Do you Want To Close The Program ?!","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Result = MessageBox.Show("Do you Want To Close The Program ?!", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu_control f8 = new Menu_control();
            f8.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info f9 = new Info();
            f9.Show();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nextPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Employee f2 = new User_Employee();
            f2.Show();
            this.Hide();
        }

        private void employeeWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login f5 = new Login();
            f5.Show();
            this.Hide();
        }

        private void searchWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_search f3 = new User_search();
            f3.Show();
            this.Hide();
        }

        private void userWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_search f3 = new User_search();
            f3.Show();
            this.Hide();
        }

        private void employeeWindowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login f5 = new Login();
            f5.Show();
            this.Hide();
        }

        private void nextPageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            User_Employee f2 = new User_Employee();
            f2.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Info f9 = new Info();
            f9.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            BackColor = Color.FromArgb(37, 46, 59);
            statusStrip1.BackColor = Color.FromArgb(26, 32, 40);
            menuStrip1.BackColor = Color.FromArgb(26, 32, 40);
            button1.BackColor = Color.FromArgb(26, 32, 40);
            button2.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            Menu_control m = new Menu_control();
            m.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Process p = new Process();
            //String str = txt1.Text;
            //ProcessStartInfo ps = new ProcessStartInfo("C:\\Users\\gaurav_joshi\\My Documents\\test.txt");
            //ps.UseShellExecute = false;
            //ps.RedirectStandardInput = true;

            //p.StartInfo = ps;
            //p.Start();

            //p.StandardInput.Write("This is a test.");
            //p.StandardInput.Flush();
            //p.StandardInput.Close();
           // Process.Start("notepad.exe", "F:\\mine\\test.txt");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Process.Start("F:\\mine\\Help File1.docx");
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Process.Start("F:\\mine\\Help File1.docx");
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

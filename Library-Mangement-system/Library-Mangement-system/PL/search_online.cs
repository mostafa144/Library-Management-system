using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Mangement_system.PL
{
    public partial class search_online : Form
    {
        public search_online()
        {
            InitializeComponent();
        }

        private void search_online_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(37, 46, 59);
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnGo_MouseHover(object sender, EventArgs e)
        {
            btnGo.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void btnGo_MouseLeave(object sender, EventArgs e)
        {

            btnGo.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            btnBack.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.ForeColor = Color.White;
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "www.google.com";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            User_search f3 = new User_search();
            f3.Show();
            this.Hide();
        }

        private void search_online_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

  }


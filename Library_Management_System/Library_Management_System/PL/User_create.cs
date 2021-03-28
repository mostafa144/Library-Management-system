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
    public partial class User_create : Form
    {
        public User_create()
        {
            InitializeComponent();
            lbl1.Text = "Date is : " + DateTime.Now + "                                      Powered By : ITI Students (Mostafa, Ali, AbdUllah)";
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
           
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (pass.Text == re_pass.Text && pass.Text!="")
            {
                if (adress.Text != "" && phone.Text != "" && ssn.Text != "" && name.Text != "")
                {
                    BL.table_opration.staff.add_staff(adress.Text, pass.Text, phone.Text, ssn.Text, name.Text, "user");
                    MessageBox.Show("New employee has been added successfully");
                }

                else
                    MessageBox.Show("make sure u fill all infos boxs");
            }
            else
              MessageBox.Show("new password and re-type do not match");
            

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Cyan;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User_info_controller f2 = new User_info_controller();
            f2.Show();
            this.Hide();
        }
    }
}

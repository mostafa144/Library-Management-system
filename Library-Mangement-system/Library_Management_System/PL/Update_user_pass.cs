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
    public partial class Update_user_pass : Form
    {
        public Update_user_pass()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Cyan;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user_old_pass.Text == BL.User.user.sf_pass)
            {
                if (user_new_pass.Text == user_new_pass_re.Text && user_new_pass.Text!="")
                {
                    BL.User.user.sf_pass = user_new_pass.Text;
                    BL.table_opration.staff.update(BL.User.user);
                }
                else
                {
                    MessageBox.Show("new password and re-type do not match or u did not put password");
                }
            }
            else
                MessageBox.Show("wrong old password");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void user_new_pass_re_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            User_info_controller f2 = new User_info_controller();
            f2.Show();
            this.Hide();
        }
    }
}

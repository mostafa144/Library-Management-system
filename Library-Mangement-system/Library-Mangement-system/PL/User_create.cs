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
    public partial class User_create : Form
    {
        public User_create()
        {
            InitializeComponent();
        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Cyan;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
        }

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Cyan;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pass.Text == re_pass.Text && pass.Text != "")
            {
                if (adress.Text != "" && phone.Text != "" && ssn.Text != "" && name.Text != "")
                    BL.table_opration.staff.add_staff(adress.Text, pass.Text, phone.Text, ssn.Text, name.Text, "user");
                else
                    MessageBox.Show("make sure u fill all infos boxs");
            }
            else
                MessageBox.Show("new password and re-type do not match");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

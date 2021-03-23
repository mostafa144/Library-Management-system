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
    public partial class User_info_controller : Form
    {
        public User_info_controller()
        {
            InitializeComponent();
            user_address.Text = BL.User.user.sf_adress;
            user_name.Text = BL.User.user.sf_user;
            user_phone.Text = BL.User.user.sf_phone;
            user_ssn.Text = BL.User.user.sf_ssn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update_user_pass f13 = new Update_user_pass();
            f13.Show();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Cyan;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Cyan;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update_user_infos f14 = new Update_user_infos();
            f14.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            User_create f7 = new User_create();
            f7.Show();
            this.Hide();
        }

        private void User_info_controller_Load(object sender, EventArgs e)
        {
            if (BL.User.user.accessablity == "user")
            {
                create_acc.Visible = false;
            }
        }
    }
}


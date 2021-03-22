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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (BL.table_opration.staff.login_make_sure(name.Text, password.Text))
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
    }
}

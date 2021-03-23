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
    public partial class Update_user_pass : Form
    {
        public Update_user_pass()
        {
            InitializeComponent();
        }

        private void btnChange_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Cyan;
        }

        private void btnChange_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user_old_pass.Text == BL.User.user.sf_pass)
            {
                if (user_new_pass.Text == user_new_pass_re.Text && user_new_pass.Text != "")
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
    }
}

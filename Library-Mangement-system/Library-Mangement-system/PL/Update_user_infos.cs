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
    public partial class Update_user_infos : Form
    {
        public Update_user_infos()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Cyan;
        }

        private void btnUpdateInfo_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (user_pass.Text == BL.User.user.sf_pass)
            {
                if (user_name.Text != "" && user_address.Text != "" && user_phone.Text != "" && user_ssn.Text != "")
                {
                    BL.User.user.sf_user = user_name.Text;
                    BL.User.user.sf_adress = user_address.Text;
                    BL.User.user.sf_phone = user_phone.Text;
                    BL.User.user.sf_ssn = user_ssn.Text;
                    BL.table_opration.staff.update(BL.User.user);
                    this.Close();
                }
                else
                    MessageBox.Show("make sure u fill all infos");
            }
            else
                MessageBox.Show("wrong old password");
        }
    }
}

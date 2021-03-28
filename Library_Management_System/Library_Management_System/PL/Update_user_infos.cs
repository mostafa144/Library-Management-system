using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Management_System
{
    public partial class Update_user_infos : Form
    {
        public Update_user_infos()
        {
            InitializeComponent();
            user_name.Text=BL.User.user.sf_user;
            user_address.Text= BL.User.user.sf_adress;
            user_phone.Text= BL.User.user.sf_phone;
            user_ssn.Text= BL.User.user.sf_ssn;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*  SqlConnection Con = database.db();
              Con.Open();
              SqlCommand Cmd = Con.CreateCommand();
              Cmd.CommandType = CommandType.StoredProcedure;
              Cmd.CommandText = "update_staff2";
              Cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = user_pass.Text.ToString();
              Cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = user_name.Text.ToString();
              Cmd.Parameters.Add("@ssn", SqlDbType.VarChar).Value = user_ssn.Text.ToString();
              Cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = user_phone.Text.ToString();
              Cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = user_address.Text.ToString();
              try
              {
                  Int32 rowsAffected = Cmd.ExecuteNonQuery();
                  System.Windows.Forms.MessageBox.Show(" Misson Completed ");
                  user_address.Text = "";
                  user_phone.Text = "";
                  user_pass.Text = "";
                  user_ssn.Text = "";
                  user_name.Text = "";

                  return;

              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.ToString());
              }*/
            if (user_pass.Text == BL.User.user.sf_pass)
            {
                if (user_name.Text != "" && user_address.Text != "" && user_phone.Text != "" && user_ssn.Text != "")
                {
                    BL.User.user.sf_user =   user_name.Text;
                    BL.User.user.sf_adress = user_address.Text;
                    BL.User.user.sf_phone =  user_phone.Text;
                    BL.User.user.sf_ssn =    user_ssn.Text;
                    BL.table_opration.staff.update(BL.User.user);
                    this.Close();
                }
                else
                    MessageBox.Show("make sure u fill all infos");
            }
            else
                MessageBox.Show("wrong old password");
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Cyan;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            User_info_controller f2 = new User_info_controller();
            f2.Show();
            this.Hide();
        }
    }
}

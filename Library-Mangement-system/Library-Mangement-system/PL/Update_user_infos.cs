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
            btnUpdateInfo.BackColor = Color.Cyan;
        }

        private void btnUpdateInfo_MouseLeave(object sender, EventArgs e)
        {
            btnUpdateInfo.BackColor = Color.White;
        }
    }
}

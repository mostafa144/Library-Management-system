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
            btnChange.BackColor = Color.Cyan;
        }

        private void btnChange_MouseLeave(object sender, EventArgs e)
        {
            btnChange.BackColor = Color.White;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Mangement_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateInformation_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateInformation_MouseHover(object sender, EventArgs e)
        {
            btnUpdateInformation.BackColor = Color.Cyan;
        }

        private void btnUpdateInformation_MouseLeave(object sender, EventArgs e)
        {
            btnUpdateInformation.BackColor = Color.White;
        }
    }
}

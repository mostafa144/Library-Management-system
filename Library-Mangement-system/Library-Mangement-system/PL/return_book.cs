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
    public partial class return_book : Form
    {
        public return_book()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            return_datagrid.DataSource = BL.table_view.borrow.Convert_to_borrows_views(BL.table_opration.borrow.search(textBox1.Text));
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (borrow_id != -1)
            {
                BL.table_opration.book.return_book(borrow_id, book_id);
                return_datagrid.DataSource = BL.table_view.borrow.Convert_to_borrows_views(BL.table_opration.borrow.return_unreterned_books());
            }
            else
                MessageBox.Show("select from table pls to return it ");
        }
    }
}

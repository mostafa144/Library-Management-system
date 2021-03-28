using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class return_book : Form
    {
        ToolTip obj;
        public return_book()
        {
            InitializeComponent();
            obj = new ToolTip();
            return_datagrid.DataSource = BL.table_view.borrow.Convert_to_borrows_views(BL.table_opration.borrow.return_unreterned_books());
            textBox1.Text = "";
        }
       
        public int borrow_id = -1;
        public int book_id = -1;
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

        private void borrow_datagrid_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in return_datagrid.SelectedRows)
            {
                borrow_id = Convert.ToInt32(row.Cells[0].Value);
                book_id= Convert.ToInt32(row.Cells[4].Value);
            }
        }

        private void button33_MouseHover(object sender, EventArgs e)
        {
           
            obj.Show("select row from table to return book", button33,7000);
            button33.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void return_book_Load(object sender, EventArgs e)
        {
            //returnbook datagridview design
            return_datagrid.BorderStyle = BorderStyle.None;
            return_datagrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            return_datagrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            return_datagrid.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            return_datagrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            return_datagrid.BackgroundColor = Color.FromArgb(26, 32, 40);

            return_datagrid.EnableHeadersVisualStyles = false;
            return_datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            return_datagrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            return_datagrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void button33_MouseLeave(object sender, EventArgs e)
        {
            button33.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            return_datagrid.DataSource = BL.table_view.borrow.Convert_to_borrows_views(BL.table_opration.borrow.search(textBox1.Text));
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Library_Management_System.PL;

namespace Library_Management_System
{
    public partial class User_search : Form
    {
        public List<DATA_AL.book> list = new List<DATA_AL.book>();
        int chose = 0;
        public User_search()
        {
            InitializeComponent();
            lbl1.Text = "Date is : " + DateTime.Now + "                                       Powered By : ITI Students (Mostafa, Ali, AbdUllah)";
            list = BL.table_opration.book.search(search.Text);
            dataGrid_book.DataSource = BL.table_view.book.Convert_to_books_views(list);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User_Employee f2 = new User_Employee();
            f2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(26, 32, 40);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            search_online f11 = new search_online();
            f11.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            search_online f11 = new search_online();
            f11.Show();
            this.Hide();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
             list= BL.table_opration.book.search(search.Text);
           
            if (chose == 1)
            {
                dataGrid_book.DataSource = BL.table_view.book.Convert_to_books_views(BL.table_opration.book.sort_by_iddesc(list));
            }
            else if (chose==2)
            {
                dataGrid_book.DataSource = BL.table_view.book.Convert_to_books_views(BL.table_opration.book.sort_by_id(list));
            }
            else if (chose == 3)
            {
                dataGrid_book.DataSource = BL.table_view.book.Convert_to_books_views(BL.table_opration.book.sort_by_alphbticdesc(list));
            }
            else if (chose == 4)
            {
                dataGrid_book.DataSource = BL.table_view.book.Convert_to_books_views(BL.table_opration.book.sort_by_alphbtic(list));
            }
            else if (chose == 5)
            {
                dataGrid_book.DataSource = BL.table_view.book.Convert_to_books_views(BL.table_opration.book.sort_by_ratedesc(list));
            }
            else if (chose == 6)
            {
                dataGrid_book.DataSource = BL.table_view.book.Convert_to_books_views(BL.table_opration.book.sort_by_rate(list));
            }
            else if (chose == 7)
            {
                dataGrid_book.DataSource = BL.table_view.book.Convert_to_books_views(BL.table_opration.book.sort_by_pagesdesc(list));
            }
            else if (chose == 8)
            {
                dataGrid_book.DataSource = BL.table_view.book.Convert_to_books_views(BL.table_opration.book.sort_by_pages(list));
            }
            else
                dataGrid_book.DataSource = BL.table_view.book.Convert_to_books_views(list);
        }

        private void radio_id_de_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_id_de.Checked == true)
            {
                chose = 1;
                dataGrid_book.DataSource = BL.table_view.book.Convert_to_books_views(BL.table_opration.book.sort_by_iddesc(list));
            }
        }

        private void radio_id_ac_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_id_ac.Checked == true)
            {
                chose = 2;
                dataGrid_book.DataSource = BL.table_view.book.Convert_to_books_views(BL.table_opration.book.sort_by_id(list));
            }
        }

        private void radio_name_de_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_name_de.Checked == true)
            {
                chose = 3;
                dataGrid_book.DataSource = BL.table_view.book.Convert_to_books_views(BL.table_opration.book.sort_by_alphbticdesc(list));
            }
        }

        private void radio_name_ac_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_name_ac.Checked == true)
            {
                chose = 4;
                dataGrid_book.DataSource = BL.table_view.book.Convert_to_books_views(BL.table_opration.book.sort_by_alphbtic(list));
            }
        }

        private void radio_rate_de_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_rate_de.Checked == true)
            {
                dataGrid_book.DataSource = BL.table_view.book.Convert_to_books_views(BL.table_opration.book.sort_by_ratedesc(list));
                chose = 5;
            }
        }

        private void radio_rate_ac_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_rate_ac.Checked == true)
            {
                dataGrid_book.DataSource = BL.table_view.book.Convert_to_books_views(BL.table_opration.book.sort_by_rate(list));
                chose = 6;
            }
        }

        private void radio_page_de_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_page_de.Checked == true)
            {
                dataGrid_book.DataSource = BL.table_view.book.Convert_to_books_views(BL.table_opration.book.sort_by_pagesdesc(list));
                chose = 7;
            }
        }

        private void radio_page_ac_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_page_ac.Checked == true)
            {
                dataGrid_book.DataSource = BL.table_view.book.Convert_to_books_views(BL.table_opration.book.sort_by_pages(list));
                chose = 8;
            }
        }

        private void User_search_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(37, 46, 59);
            groupBox1.BackColor = Color.FromArgb(37, 46, 59);
            groupBox2.BackColor = Color.FromArgb(37, 46, 59);
            groupBox3.BackColor = Color.FromArgb(37, 46, 59);
            groupBox4.BackColor = Color.FromArgb(37, 46, 59);
            groupBox5.BackColor = Color.FromArgb(37, 46, 59);
            groupBox6.BackColor = Color.FromArgb(37, 46, 59);
            search.BackColor = Color.FromArgb(26, 32, 40);
            label2.BackColor = Color.FromArgb(26, 32, 40);
            button2.BackColor = Color.FromArgb(26, 32, 40);
            statusStrip1.BackColor = Color.FromArgb(26, 32, 40);
           // button1.BackColor = Color.FromArgb(26, 32, 40);
            //User datagridviewdesign
            dataGrid_book.BorderStyle = BorderStyle.None;
            dataGrid_book.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGrid_book.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGrid_book.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGrid_book.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGrid_book.BackgroundColor = Color.FromArgb(26,32,40);

            dataGrid_book.EnableHeadersVisualStyles = false;
            dataGrid_book.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGrid_book.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGrid_book.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            //button1.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
           // button1.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Process.Start("F:\\mine\\Help File2.docx");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RoomChat frm = new RoomChat();
            frm.Show();
        }
        private void button4_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(26, 32, 40);

        }

        private void dataGrid_book_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

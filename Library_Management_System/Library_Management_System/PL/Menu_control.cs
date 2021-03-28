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
using System.Diagnostics;
using Library_Management_System.PL;

namespace Library_Management_System
{
    public partial class Menu_control : Form
    {
        public ToolTip tooltip;
        public Menu_control()
        {
            tooltip = new ToolTip();
            InitializeComponent();
            lbl1.Text = "Date is : " + DateTime.Now + "                                  Powered By : ITI Students (Mostafa, Ali, AbdUllah)";
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Info f9 = new Info();
            f9.Show();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Blue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Blue;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
           // button3.BackColor = Color.White;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            //button3.BackColor = Color.Blue;
        }

        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();

        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.Cyan;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.White;
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            button6.BackColor = Color.Cyan;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.White;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Color.White;
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            button7.BackColor = Color.Cyan;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //report f10 = new report();
            //f10.Show();
        }

        private void button5_MouseHover_1(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void button5_MouseLeave_1(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button6_MouseHover_1(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void button6_MouseLeave_1(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button7_MouseHover_1(object sender, EventArgs e)
        {
            button7.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void button7_MouseLeave_1(object sender, EventArgs e)
        {
            button7.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button1_MouseHover_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(20, 25, 72);
        }

        private void button1_MouseLeave_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button2_MouseHover_1(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(20, 25, 72);
        }

        private void button2_MouseLeave_1(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button3_MouseHover_1(object sender, EventArgs e)
        {
            //button3.BackColor = Color.FromArgb(20, 25, 72);
        }

        private void button3_MouseLeave_1(object sender, EventArgs e)
        {
            //button3.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(20, 25, 72);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login f5 = new Login();
            f5.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Info f9 = new Info();
            f9.Show();
        }


        private void button8_MouseHover(object sender, EventArgs e)
        {
            button8.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            button9.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button10_MouseHover(object sender, EventArgs e)
        {
            button10.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button11_MouseHover(object sender, EventArgs e)
        {
            button11.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button12_MouseHover(object sender, EventArgs e)
        {
            button12.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            button12.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button13_MouseHover(object sender, EventArgs e)
        {
            button13.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            button13.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button14_MouseHover(object sender, EventArgs e)
        {
            button14.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void button14_MouseLeave(object sender, EventArgs e)
        {
            button14.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button15_MouseHover(object sender, EventArgs e)
        {
            button15.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void button15_MouseLeave(object sender, EventArgs e)
        {
            button15.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button16_MouseHover(object sender, EventArgs e)
        {
            button16.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void button16_MouseLeave(object sender, EventArgs e)
        {
            button16.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button18_MouseHover(object sender, EventArgs e)
        {
            button18.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void button18_MouseLeave(object sender, EventArgs e)
        {
            button18.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button19_MouseHover(object sender, EventArgs e)
        {
            button19.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void button19_MouseLeave(object sender, EventArgs e)
        {
            button19.BackColor = Color.FromArgb(26, 32, 40);
        }



        private void button21_MouseHover(object sender, EventArgs e)
        {
            button21.BackColor = Color.Red;
        }

        private void button21_MouseLeave(object sender, EventArgs e)
        {
            button21.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button22_MouseHover(object sender, EventArgs e)
        {
            button22.BackColor = Color.Red;
        }

        private void button22_MouseLeave(object sender, EventArgs e)
        {
            button22.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button23_MouseHover(object sender, EventArgs e)
        {
            button23.BackColor = Color.Red;
        }

        private void button23_MouseLeave(object sender, EventArgs e)
        {
            button23.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button24_MouseHover(object sender, EventArgs e)
        {
            button24.BackColor = Color.Red;
        }

        private void button24_MouseLeave(object sender, EventArgs e)
        {
            button24.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button28_MouseHover(object sender, EventArgs e)
        {
            button28.BackColor = Color.Red;
        }

        private void button28_MouseLeave(object sender, EventArgs e)
        {
            button28.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button27_MouseHover(object sender, EventArgs e)
        {
            button27.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void button27_MouseLeave(object sender, EventArgs e)
        {
            button27.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button26_MouseHover(object sender, EventArgs e)
        {
            button26.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void button26_MouseLeave(object sender, EventArgs e)
        {
            button26.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button25_MouseHover(object sender, EventArgs e)
        {
            button25.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void button25_MouseLeave(object sender, EventArgs e)
        {
            button25.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void firstPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Welcome f1 = new Welcome();
            f1.Show();
            this.Hide();
        }

        private void logInPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login f5 = new Login();
            f5.Show();
            this.Hide();
        }

        private void searchPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_search f3 = new User_search();
            f3.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Info f9 = new Info();
            f9.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_info_controller f12 = new User_info_controller();
            f12.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_info_controller f12 = new User_info_controller();
            f12.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (bool_category())
            {
                SqlConnection Con = database.db();
                Con.Open();
                SqlCommand Cmd = Con.CreateCommand();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "insert_categorie";
                Cmd.Parameters.Add("@id", SqlDbType.Int).Value = BL.table_opration.categorie.NextID();
                Cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = category_name.Text.ToString();
                try
                {
                    Int32 rowsAffected = Cmd.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show(" process Completed ");
                    refresh_category();
                    return;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    refresh_category();
                }
            }
            else
                MessageBox.Show("make sure you fill name box");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (bool_category() && category_id.Name != category_id.Text)
            {
                if (BL.table_opration.categorie.search(Convert.ToInt32(category_id.Text)) != null)
                {
                    SqlConnection Con = database.db();
                    Con.Open();
                    SqlCommand Cmd = Con.CreateCommand();
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.CommandText = "update_categorie";
                    Cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(category_id.Text);
                    Cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = category_name.Text.ToString();
                    try
                    {
                        Int32 rowsAffected = Cmd.ExecuteNonQuery();
                        System.Windows.Forms.MessageBox.Show(" process Completed ");
                        refresh_category();

                        return;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        refresh_category();
                    }
                }
                else
                    MessageBox.Show("make sure you put correct id ");
            }
            else
                MessageBox.Show("make sure you fill all information id and name");

        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (category_id.Name != category_id.Text)
            {
                if (BL.table_opration.categorie.search(Convert.ToInt32(category_id.Text)) != null)
                {
                    if (!BL.table_opration.categorie.has_relation(Convert.ToInt32(category_id.Text)))
                    {
                        SqlConnection Con = database.db();
                        Con.Open();
                        SqlCommand Cmd = Con.CreateCommand();
                        Cmd.CommandType = CommandType.StoredProcedure;
                        Cmd.CommandText = "delete_categorie";
                        Cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(category_id.Text);
                        try
                        {
                            Int32 rowsAffected = Cmd.ExecuteNonQuery();
                            System.Windows.Forms.MessageBox.Show(" process Completed ");
                            refresh_category();
                            return;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                            refresh_category();
                        }
                    }
                    else
                        MessageBox.Show("this categore have books, delete them first then you will able to delete this categore");
                }
                else
                    MessageBox.Show("make sure you put correct id ");
            }
            else
                MessageBox.Show("make sure you fill information id ");

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (bool_publisher())
            {
                SqlConnection Con = database.db();
                Con.Open();
                SqlCommand Cmd = Con.CreateCommand();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "insert_publisher";

                Cmd.Parameters.Add("@pname", SqlDbType.VarChar).Value = publisher_name.Text.ToString();
                Cmd.Parameters.Add("@paddress", SqlDbType.VarChar).Value = publisher_address.Text.ToString();
                //    Cmd.Parameters.Add("@bookid", SqlDbType.Int).Value = Convert.ToInt32(textBox30.Text); what this is??
                try
                {
                    Int32 rowsAffected = Cmd.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show(" process Completed ");

                    //  textBox30.Text = ""; mistake 0_0
                    refresh_publisher();
                    return;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    refresh_publisher();
                }
            }
            else
                MessageBox.Show("make sure you fill informations expect id ");

            //  textBox30.Text = "";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (bool_publisher() && publisher_id.Name != publisher_id.Text)
            {
                if (BL.table_opration.publisher.search_id(Convert.ToInt32(publisher_id.Text)) != null)
                {
                    SqlConnection Con = database.db();
                    Con.Open();
                    SqlCommand Cmd = Con.CreateCommand();
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.CommandText = "update_publisher";
                    Cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(publisher_id.Text);
                    Cmd.Parameters.Add("@pname", SqlDbType.VarChar).Value = publisher_name.Text.ToString();
                    Cmd.Parameters.Add("@paddress", SqlDbType.VarChar).Value = publisher_address.Text.ToString();
                    try
                    {
                        Int32 rowsAffected = Cmd.ExecuteNonQuery();
                        System.Windows.Forms.MessageBox.Show(" process Completed ");
                        BL.table_opration.publisher.update(Convert.ToInt32(publisher_id.Text), publisher_name.Text, publisher_address.Text);
                        //    textBox30.Text = "";
                        refresh_publisher();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        refresh_publisher();
                    }
                }
                else
                    MessageBox.Show("make sure you put correct id ");
            }
            else
                MessageBox.Show("make sure you fill all informations  ");
            refresh_publisher();

        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (publisher_id.Name != publisher_id.Text)
            {
                if (BL.table_opration.publisher.search_id(Convert.ToInt32(publisher_id.Text)) != null)
                {
                    if (BL.table_opration.Many_book_publisher.get_publisher_books(Convert.ToInt32(publisher_id.Text)).Count > 0)
                    MessageBox.Show("this publishers has books delete books first to delete this publisher");
                else
                {
                    SqlConnection Con = database.db();
                    Con.Open();
                    SqlCommand Cmd = Con.CreateCommand();
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.CommandText = "delete_publisher";
                    Cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(publisher_id.Text);
                    try
                    {
                        Int32 rowsAffected = Cmd.ExecuteNonQuery();
                        System.Windows.Forms.MessageBox.Show(" process Completed ");

                        refresh_publisher();
                        return;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        refresh_publisher();
                    }
                }
                }
                else
                    MessageBox.Show("make sure you put correct id ");
            }
            else
                MessageBox.Show("make sure you fill id information");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (bool_author())
            {
                SqlConnection Con = database.db();
                Con.Open();
                SqlCommand Cmd = Con.CreateCommand();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "insertt_author";
                Cmd.Parameters.Add("@authorname", SqlDbType.VarChar).Value = author_name.Text.ToString();
                try
                {
                    Int32 rowsAffected = Cmd.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show(" process Completed ");
                    refresh_author();
                    return;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    refresh_author();
                }
            }
            else
                MessageBox.Show("make sure you fill name box");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (bool_author() && author_id.Name != author_id.Text)
            {
                if (BL.table_opration.author.search(Convert.ToInt32(author_id.Text)) != null)
                {
                    SqlConnection Con = database.db();
                    Con.Open();
                    SqlCommand Cmd = Con.CreateCommand();
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.CommandText = "update_author";
                    Cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(author_id.Text);
                    Cmd.Parameters.Add("@authorname", SqlDbType.VarChar).Value = author_name.Text;
                    try
                    {
                        Int32 rowsAffected = Cmd.ExecuteNonQuery();
                        System.Windows.Forms.MessageBox.Show(" process Completed ");
                        refresh_author();

                        return;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        refresh_author();
                    }
                }
                else
                    MessageBox.Show("make sure you put correct id");
            }
            else
                MessageBox.Show("make sure you fill name and id boxs");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (bool_author() && author_id.Name != author_id.Text)
            {
                if (BL.table_opration.author.search(Convert.ToInt32(author_id.Text)) != null)
                {
                    if (!BL.table_opration.author.has_relation(Convert.ToInt32(author_id.Text)))
                    {
                        SqlConnection Con = database.db();
                        Con.Open();
                        SqlCommand Cmd = Con.CreateCommand();
                        Cmd.CommandType = CommandType.StoredProcedure;
                        Cmd.CommandText = "delete_author";
                        Cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(author_id.Text);
                        try
                        {
                            Int32 rowsAffected = Cmd.ExecuteNonQuery();
                            System.Windows.Forms.MessageBox.Show(" process Completed ");
                            refresh_author();

                            return;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                            refresh_author();
                        }
                    }
                    else
                        MessageBox.Show("this author have books delete , them first then you will able to delete this author");
                }
                else
                    MessageBox.Show("make sure you put correct id");
            }
            else
                MessageBox.Show("make sure you fill  id box");

        }

        private void button5_Click(object sender, EventArgs e)
        {

            /* SqlConnection Con = database.db();
             Con.Open();
             SqlCommand Cmd = Con.CreateCommand();
             Cmd.CommandType = CommandType.StoredProcedure;
             Cmd.CommandText = "insert_book";
             Cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = book_title.Text.ToString();
             Cmd.Parameters.Add("@pages", SqlDbType.Int).Value = Convert.ToInt32(page_number.Text);
             Cmd.Parameters.Add("@map_plates", SqlDbType.NVarChar).Value = accessories.Text.ToString();
             Cmd.Parameters.Add("@rate", SqlDbType.Int).Value = Convert.ToInt32(rate.Text);
             Cmd.Parameters.Add("@notes", SqlDbType.NVarChar).Value = richTextBox1.Text.ToString();
             Cmd.Parameters.Add("@language", SqlDbType.NVarChar).Value = languge.Text.ToString();
             Cmd.Parameters.Add("@volume", SqlDbType.Int).Value = Convert.ToInt32(volume.Text);
             Cmd.Parameters.Add("@publication_year", SqlDbType.DateTime).Value = Convert.ToDateTime(publication_year.Text);
             Cmd.Parameters.Add("@authors_id", SqlDbType.Int).Value = Convert.ToInt32(author.SelectedValue);
             Cmd.Parameters.Add("@price", SqlDbType.Float).Value = Convert.ToDecimal(price.Text);
             Cmd.Parameters.Add("@entry_date", SqlDbType.DateTime).Value = Convert.ToDateTime(entry_date.Text);
             Cmd.Parameters.Add("@parts", SqlDbType.Int).Value = Convert.ToInt32(parts.Text);
             Cmd.Parameters.Add("@categories_id", SqlDbType.Int).Value = Convert.ToInt32(category.SelectedValue);
             try
             {
                 Int32 rowsAffected = Cmd.ExecuteNonQuery();
                 System.Windows.Forms.MessageBox.Show(" Misson Completed ");


             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString());
             }*/
            if (bool_book())
            {
                DATA_AL.book book = BL.table_opration.book.add_book(book_title.Text, book_note.Text, Convert.ToInt32(page_number.Text), Convert.ToInt32(parts.Text), Convert.ToInt32(rate.Text),
                 Convert.ToInt32(volume.Text), Convert.ToInt32(category.SelectedValue), false, languge.Text, accessories.Text, Convert.ToDouble(price.Text),
                 publication_year.Value.Date, Convert.ToInt32(author.SelectedValue), entry_date.Value.Date);
                BL.table_opration.Many_book_publisher.Add_relation(book.bk_id, Convert.ToInt32(publisher.SelectedValue));

                refresh_book();
            }
            else
                MessageBox.Show("make sure that u put all information except id");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /* SqlConnection Con = database.db();
             Con.Open();
             SqlCommand Cmd = Con.CreateCommand();
             Cmd.CommandType = CommandType.StoredProcedure;
             Cmd.CommandText = "update_book";
             Cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(book_id.Text);
             Cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = book_title.Text.ToString();
             Cmd.Parameters.Add("@pages", SqlDbType.Int).Value = Convert.ToInt32(page_number.Text);
             Cmd.Parameters.Add("@map_plates", SqlDbType.NVarChar).Value = accessories.Text.ToString();
             Cmd.Parameters.Add("@rate", SqlDbType.Int).Value = Convert.ToInt32(rate.Text);
             Cmd.Parameters.Add("@notes", SqlDbType.NVarChar).Value = book_note.Text.ToString();
             Cmd.Parameters.Add("@language", SqlDbType.NVarChar).Value = languge.Text.ToString();
             Cmd.Parameters.Add("@volume", SqlDbType.Int).Value = Convert.ToInt32(volume.Text);
             Cmd.Parameters.Add("@publication_year", SqlDbType.DateTime).Value = Convert.ToDateTime(publication_year.Text);
             Cmd.Parameters.Add("@authors_id", SqlDbType.Int).Value = Convert.ToInt32(author.SelectedValue);
             Cmd.Parameters.Add("@price", SqlDbType.Float).Value = Convert.ToDecimal(price.Text);
             Cmd.Parameters.Add("@entry_date", SqlDbType.DateTime).Value = Convert.ToDateTime(entry_date.Text);
             Cmd.Parameters.Add("@parts", SqlDbType.Int).Value = Convert.ToInt32(parts.Text);
             Cmd.Parameters.Add("@categories_id", SqlDbType.Int).Value = Convert.ToInt32(category.SelectedValue);
             try
             {
                 Int32 rowsAffected = Cmd.ExecuteNonQuery();
                 System.Windows.Forms.MessageBox.Show(" Misson Completed ");
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString());
             }*/
            if (bool_book() && book_id.Name != book_id.Text)
            {
                if (BL.table_opration.book.search(Convert.ToInt32(book_id.Text)) != null)
                {
                    DATA_AL.book book = BL.table_opration.book.update(Convert.ToInt32(book_id.Text), book_title.Text, book_note.Text, Convert.ToInt32(page_number.Text), Convert.ToInt32(parts.Text), Convert.ToInt32(rate.Text),
                  Convert.ToInt32(volume.Text), Convert.ToInt32(category.SelectedValue), false, languge.Text, accessories.Text, Convert.ToDouble(price.Text),
                  publication_year.Value.Date, Convert.ToInt32(author.SelectedValue), entry_date.Value.Date);
                    BL.table_opration.Many_book_publisher.Update_relation(Convert.ToInt32(publisher.SelectedValue), book.bk_id);
                    refresh_book();
                }
                else
                    MessageBox.Show("make sure that u put correct id  ");
            }
            else
                MessageBox.Show("make sure that u put all information ");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            /* SqlConnection Con = database.db();
             Con.Open();
             SqlCommand Cmd = Con.CreateCommand();
             Cmd.CommandType = CommandType.StoredProcedure;
             Cmd.CommandText = "delete_book";
             Cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(book_id.Text);
             try
             {
                 Int32 rowsAffected = Cmd.ExecuteNonQuery();
                 System.Windows.Forms.MessageBox.Show(" Misson Completed ");
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString());
             }*/
            if (book_id.Name != book_id.Text)
            {
                if (BL.table_opration.book.search(Convert.ToInt32(book_id.Text)) != null)
                {
                    List<DATA_AL.borrow> list = BL.table_opration.Many_book_borrow.get_book_borrows(Convert.ToInt32(book_id.Text));
                    if (list.Count > 0)
                    {
                        var xx = MessageBox.Show("this book has borrow log do u want to delete it ", "sure", MessageBoxButtons.YesNo);
                        string yy = Convert.ToString(xx);
                        if (yy == "Yes")
                        {
                            if (BL.User.user.accessablity == "admin")
                            {
                                BL.table_opration.borrow.delete(list);
                                BL.table_opration.Many_book_publisher.Delete_relation(Convert.ToInt32(book_id.Text), Convert.ToInt32(publisher.SelectedValue));
                                BL.table_opration.book.delete(Convert.ToInt32(book_id.Text));
                                refresh_book();
                            }
                            else
                            {
                                MessageBox.Show("access deny u are not allowed to delete this book with his borrow log ,u are not admin");
                            }
                        }
                    }
                    else
                    {
                        BL.table_opration.Many_book_publisher.Delete_relation(Convert.ToInt32(book_id.Text), Convert.ToInt32(publisher.SelectedValue));
                        BL.table_opration.book.delete(Convert.ToInt32(book_id.Text));
                        refresh_book();
                    }
                }
                else
                    MessageBox.Show("make sure that u put correct id  ");
            }
            else
                MessageBox.Show("make sure that u put id info ");
        }



        private void button29_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            //Employee_Search f3 = new Employee_Search();
            //f3.Show();
            //this.Hide();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Login f5 = new Login();
            f5.Show();
            this.Hide();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            OnlineSearch f11 = new OnlineSearch();
            f11.Show();
            this.Hide();

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {
            // var txt = (TextBox)sender;
            //  BL.handle.focus(this,1,txt.Name);
            BL.handle.focus(sender);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                user_name.Text = BL.User.user.sf_user;
                user_access.Text = BL.User.user.accessablity;

            }
            if (tabControl1.SelectedIndex == 1)
            {
                refresh_book();
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                refresh_category();
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                refresh_author();
            }
            else if (tabControl1.SelectedIndex == 4)
            {
                refresh_publisher();
            }
            else if (tabControl1.SelectedIndex == 5)
            {
                refresh_borrower();
            }
            else if (tabControl1.SelectedIndex == 6)
            {
                refresh_borrow();
            }
        }

        private void book_id_TextChanged(object sender, EventArgs e)
        {
           BL.handle.handle_int_txt(sender, 9);
        }

        private void rate_TextChanged(object sender, EventArgs e)
        {
            BL.handle.handle_int_txt(sender, 1);
        }

        private void price_TextChanged(object sender, EventArgs e)
        {
            BL.handle.handle_float_txt(sender, 8);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            refresh_book();
        }
        public void refresh_book()
        {
            BL.handle.txt_focus_work = true;
            category.DataSource = BL.table_opration.categorie.return_all();
            category.DisplayMember = "ct_name";
            category.ValueMember = "ct_id";
            category.SelectedIndex = -1;

            author.DataSource = BL.table_opration.author.return_all();
            author.DisplayMember = "ah_name";
            author.ValueMember = "ah_id";
            author.SelectedIndex = -1;

            publisher.DataSource = BL.table_opration.publisher.return_all();
            publisher.DisplayMember = "pp_name";
            publisher.ValueMember = "pp_id";
            publisher.SelectedIndex = -1;

            book_grid.DataSource = BL.table_view.book.Convert_to_books_views(BL.table_opration.book.get_all_books());

            book_id.Text = book_id.Name;
            book_title.Text = book_title.Name;
            page_number.Text = page_number.Name;
            volume.Text = volume.Name;
            languge.Text = languge.Name;
            accessories.Text = accessories.Name;
            parts.Text = parts.Name;
            rate.Text = rate.Name;
            price.Text = price.Name;
            book_note.Text = book_note.Name;
            book_note.ForeColor = Color.Gray;
            book_note.MaxLength = 80;
            convert_color_gray(re_book());
            limit_size_txt(re_book());
            BL.handle.txt_focus_work = false;
        }
        public void refresh_borrow()
        {
            book.DataSource = BL.table_opration.book.get_all_books();
            book.DisplayMember = "bk_name";
            book.ValueMember = "bk_id";
            book.SelectedIndex = -1;

            borrower.DataSource = BL.table_opration.borrower.return_all();
            borrower.DisplayMember = "bwr_name";
            borrower.ValueMember = "bwr_id";
            borrower.SelectedIndex = -1;

            borrow_datagrid.DataSource = BL.table_view.borrow.Convert_to_borrows_views(BL.table_opration.borrow.return_all());
            cmb_book_id.Text = "";
            cmb_borrower_code.Text = "";
            convert_color_gray(re_borrow());
        }
        public void refresh_category()
        {
            BL.handle.txt_focus_work = true;
            category_datagrid.DataSource = BL.table_view.category.Convert_to_categorys_views(BL.table_opration.categorie.return_all());
            category_id.Text = category_id.Name;
            category_name.Text = category_name.Name;
            convert_color_gray(re_categore());
            limit_size_txt(re_categore());
            BL.handle.txt_focus_work = false;
        }
        public void refresh_author()
        {
            BL.handle.txt_focus_work = true;
            author_datagrid.DataSource = BL.table_view.author.Convert_to_authors_views(BL.table_opration.author.return_all());
            author_id.Text = author_id.Name;
            author_name.Text = author_name.Name;
            convert_color_gray(re_author());
            limit_size_txt(re_author());
            BL.handle.txt_focus_work = false;

        }
        public void refresh_publisher()
        {
            BL.handle.txt_focus_work = true;
            publisher_datagrid.DataSource = BL.table_view.publisher.Convert_to_publishers_views(BL.table_opration.publisher.return_all());
            publisher_id.Text = publisher_id.Name;
            publisher_name.Text = publisher_name.Name;
            publisher_address.Text = publisher_address.Name;
            convert_color_gray(re_publisher());
            limit_size_txt(re_publisher());
            BL.handle.txt_focus_work = false;

        }
        public void refresh_borrower()
        {
            BL.handle.txt_focus_work = true;
            borrower_datagrid.DataSource = BL.table_view.borrower.Convert_to_borrowers_views(BL.table_opration.borrower.return_all());
            borrower_id.Text = borrower_id.Name;
            borrower_name.Text = borrower_name.Name;
            borrower_address.Text = borrower_address.Name;
            borrower_code.Text = borrower_code.Name;
            borrower_phone.Text = borrower_phone.Name;
            borrower_rank.Text = borrower_rank.Name;
            convert_color_gray(re_borrower());
            limit_size_txt(re_borrower());
            BL.handle.txt_focus_work = false;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            refresh_category();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            refresh_author();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            refresh_publisher();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (bool_borrower())
            {
                BL.table_opration.borrower.add_borrower(borrower_name.Text, borrower_phone.Text, borrower_rank.Text, borrower_code.Text, borrower_address.Text);
                refresh_borrower();
            }
            else
                MessageBox.Show("make sure that you fill all information except id");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (bool_borrower() && borrower_id.Name != borrower_id.Text)
            {
                if (BL.table_opration.borrower.search(Convert.ToInt32(borrower_id.Text)) != null)
                {
                    BL.table_opration.borrower.update(Convert.ToInt32(borrower_id.Text), borrower_name.Text, borrower_phone.Text, borrower_rank.Text, borrower_code.Text, borrower_address.Text);
                    refresh_borrower();
                }
                else
                    MessageBox.Show("make sure that you put correct id");

            }
            else
                MessageBox.Show("make sure that you fill all information");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            refresh_borrower();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (borrower_id.Name != borrower_id.Text)
            {
                if (BL.table_opration.borrower.search(Convert.ToInt32(borrower_id.Text)) != null)
                {
                    List<DATA_AL.borrow> list = BL.table_opration.borrower.get_borrow_log(Convert.ToInt32(borrower_id.Text));
                    if (list.Count > 0)
                    {
                        var xx = MessageBox.Show("this borrower has borrow log do u want to delete it ", "sure", MessageBoxButtons.YesNo);
                        string yy = Convert.ToString(xx);
                        if (yy == "Yes")
                        {
                            if (BL.User.user.accessablity == "admin")
                            {
                                BL.table_opration.borrow.delete(list);
                                BL.table_opration.borrower.delete(Convert.ToInt32(borrower_id.Text));
                                refresh_borrower();
                            }
                            else
                                MessageBox.Show("access deny to delete this borrower and his log, he has borrow log you are not admin to delete it");
                        }
                    }
                    else
                    {
                        BL.table_opration.borrower.delete(Convert.ToInt32(borrower_id.Text));
                        refresh_borrower();
                    }

                }
                else
                    MessageBox.Show("make sure that you put correct id information");
            }
            else
                MessageBox.Show("make sure that you fill id information");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (bool_borrow())
            {
                //////////////////////////////////////////////////////////////////////////error 1___
                if (BL.table_opration.book.search(Convert.ToInt32(book.SelectedValue)).bk_volume != 0)
                {
                    int borrower_id = BL.table_opration.borrower.search(Convert.ToInt32(borrower.SelectedValue)).bwr_id;
                    int book_id = BL.table_opration.book.search(Convert.ToInt32(book.SelectedValue)).bk_id;
                    BL.table_opration.book.search(Convert.ToInt32(book.SelectedValue)).bk_volume--;
                    BL.table_opration.borrow.add_borrow(borrower_id, date_in.Value.Date, date_out.Value.Date, false);
                    BL.table_opration.Many_book_borrow.Add_relation(book_id, BL.table_opration.borrow.NextID() - 1);////edited
                    refresh_borrow();
                }
                else
                    MessageBox.Show("make sure that book had been returned  , it has no copy left");
            }
            else
                MessageBox.Show("make sure that you fill all information");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (bool_borrow() && borrow_id.Name != borrow_id.Text )
            {
                if (BL.table_opration.borrow.search(Convert.ToInt32(borrow_id.Text)).Count == 1)
                {
                    int borrower_id = BL.table_opration.borrower.search(Convert.ToInt32(borrower.SelectedValue)).bwr_id;
                    int book_id = BL.table_opration.book.search(Convert.ToInt32(book.SelectedValue)).bk_id;
                    BL.table_opration.borrow.update(Convert.ToInt32(borrow_id.Text), borrower_id, date_in.Value.Date, date_out.Value.Date, false);
                    BL.table_opration.Many_book_borrow.Update_relation(Convert.ToInt32(borrow_id.Text), book_id);
                    refresh_borrow();
                }
                else
                    MessageBox.Show("put correct id");
            }
            else
                MessageBox.Show("make sure that you fill id and all information  ");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            refresh_borrow();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (borrow_id.Name != borrow_id.Text)
            {
                if (BL.table_opration.borrow.search(Convert.ToInt32(borrow_id.Text)).Count == 1)
                {
                    int book_id = BL.table_opration.Many_book_borrow.get_borrow_books(Convert.ToInt32(borrow_id.Text))[0].bk_id;
                    if (BL.table_opration.borrow.search_id(Convert.ToInt32(borrow_id.Text)).returned == false)
                    {
                        BL.table_opration.book.search(book_id).bk_volume++;
                    }
                    BL.table_opration.Many_book_borrow.Delete_relation(book_id, Convert.ToInt32(borrow_id.Text));
                    BL.table_opration.borrow.delete(Convert.ToInt32(borrow_id.Text));
                    refresh_borrow();
                }
            else
                MessageBox.Show("put correct id");
        }
            else
                MessageBox.Show("make sure that you fill id info ");
        }

        private void book_DropDownClosed(object sender, EventArgs e)
        {
            if (book.SelectedIndex != -1)
                cmb_book_id.Text = BL.table_opration.book.search(Convert.ToInt32(book.SelectedValue)).bk_id.ToString();

        }

        private void borrower_DropDownClosed(object sender, EventArgs e)
        {
            if (borrower.SelectedIndex != -1)
                cmb_borrower_code.Text = BL.table_opration.borrower.search(Convert.ToInt32(borrower.SelectedValue)).bwr_code.ToString();
        }

        private void Menu_control_Load(object sender, EventArgs e)
        {
            tabControl1_SelectedIndexChanged(sender, e);
            
            //Book datagridview design
            book_grid.BorderStyle = BorderStyle.None;
            book_grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            book_grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            book_grid.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            book_grid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            book_grid.BackgroundColor = Color.FromArgb(26 ,32 ,40);

            book_grid.EnableHeadersVisualStyles = false;
            book_grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            book_grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            book_grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            //Category datagridview design
            category_datagrid.BorderStyle = BorderStyle.None;
            category_datagrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            category_datagrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            category_datagrid.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            category_datagrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            category_datagrid.BackgroundColor = Color.FromArgb(26, 32, 40);

            category_datagrid.EnableHeadersVisualStyles = false;
            category_datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            category_datagrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            category_datagrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            //Author datagridview design
            author_datagrid.BorderStyle = BorderStyle.None;
            author_datagrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            author_datagrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            author_datagrid.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            author_datagrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            author_datagrid.BackgroundColor = Color.FromArgb(26, 32, 40);

            author_datagrid.EnableHeadersVisualStyles = false;
            author_datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            author_datagrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            author_datagrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            //Publisher datagridview design
            publisher_datagrid.BorderStyle = BorderStyle.None;
            publisher_datagrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            publisher_datagrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            publisher_datagrid.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            publisher_datagrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            publisher_datagrid.BackgroundColor = Color.FromArgb(26, 32, 40);

            publisher_datagrid.EnableHeadersVisualStyles = false;
            publisher_datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            publisher_datagrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            publisher_datagrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            //Borrower datagridvieew design
            borrower_datagrid.BorderStyle = BorderStyle.None;
            borrower_datagrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            borrower_datagrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            borrower_datagrid.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            borrower_datagrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            borrower_datagrid.BackgroundColor = Color.FromArgb(26, 32, 40);

            borrower_datagrid.EnableHeadersVisualStyles = false;
            borrower_datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            borrower_datagrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            borrower_datagrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            //Borrow datagridview design
            borrow_datagrid.BorderStyle = BorderStyle.None;
            borrow_datagrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            borrow_datagrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            borrow_datagrid.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            borrow_datagrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            borrow_datagrid.BackgroundColor = Color.FromArgb(26, 32, 40);

            borrow_datagrid.EnableHeadersVisualStyles = false;
            borrow_datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            borrow_datagrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            borrow_datagrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            return_book form = new return_book();
            form.ShowDialog();
            refresh_borrow();
        }

        private void book_id_MouseEnter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            string table = txt.Name.Remove(txt.Name.Length - 1 - 2);
            tooltip.Show(txt.Name + " is used only for update and delete in table of " + table, txt, 7000);
        }
        public void fill_book(DATA_AL.book book)
        {
            if (book.bk_id != 0)
            {
                convert_color_black(re_book());
                book_id.Text = book.bk_id.ToString();
                book_title.Text = book.bk_name;
                page_number.Text = book.bk_pages.ToString();
                volume.Text = book.bk_volume.ToString();
                languge.Text = book.language;
                accessories.Text = book.map_plates;
                parts.Text = book.bk_parts.ToString();
                rate.Text = book.bk_rate.ToString();
                price.Text = book.price.ToString();
                book_note.Text = book.bk_notes;
                book_note.ForeColor = Color.White;
                publication_year.Value = book.publication_year.Value;
                entry_date.Value = book.bk_entry_date.Value;
                publisher.SelectedIndex = publisher.FindStringExact(BL.table_opration.Many_book_publisher.get_book_publishers(book.bk_id)[0].pp_name);
                author.SelectedIndex = author.FindStringExact(book.author.ah_name);
                category.SelectedIndex = category.FindStringExact(book.categorie.ct_name);
            }
        }
        public List<TextBox> re_book()
        {
            List<TextBox> txts = new List<TextBox>();
            txts.Add(book_id);
            txts.Add(book_title);
            txts.Add(page_number);
            txts.Add(volume);
            txts.Add(languge);
            txts.Add(accessories);
            txts.Add(parts);
            txts.Add(rate);
            txts.Add(price);
            return txts;
        }
        public void fill_author(DATA_AL.author author)
        {
            if (author.ah_id != 0)
            {
                convert_color_black(re_author());
                author_id.Text = author.ah_id.ToString();
                author_name.Text = author.ah_name;
            }
        }
        public List<TextBox> re_author()
        {
            List<TextBox> txts = new List<TextBox>();
            txts.Add(author_id);
            txts.Add(author_name);
            return txts;
        }
        public void fill_categorie(DATA_AL.categorie categorie)
        {
            if (categorie.ct_id != 0)
            {
                convert_color_black(re_categore());
                category_id.Text = categorie.ct_id.ToString();
                category_name.Text = categorie.ct_name;
            }
        }
        public List<TextBox> re_categore()
        {
            List<TextBox> txts = new List<TextBox>();
            txts.Add(category_id);
            txts.Add(category_name);
            return txts;
        }
        public void fill_publisher(DATA_AL.publisher publisher)
        {
            if (publisher.pp_id != 0)
            {
                convert_color_black(re_publisher());
                publisher_id.Text = publisher.pp_id.ToString();
                publisher_name.Text = publisher.pp_name;
                publisher_address.Text = publisher.pp_address;
            }
        }
        public List<TextBox> re_publisher()
        {
            List<TextBox> txts = new List<TextBox>();
            txts.Add(publisher_id);
            txts.Add(publisher_name);
            txts.Add(publisher_address);
            return txts;
        }
        public void fill_borrower(DATA_AL.borrower borrower)
        {
            if (borrower.bwr_id != 0)
            {
                convert_color_black(re_borrower());
                borrower_id.Text = borrower.bwr_id.ToString();
                borrower_name.Text = borrower.bwr_name;
                borrower_address.Text = borrower.bwr_address;
                borrower_code.Text = borrower.bwr_code;
                borrower_rank.Text = borrower.bwr_rank;
                borrower_phone.Text = borrower.bwr_phone;
            }
        }
        public List<TextBox> re_borrower()
        {
            List<TextBox> txts = new List<TextBox>();
            txts.Add(borrower_id);
            txts.Add(borrower_name);
            txts.Add(borrower_address);
            txts.Add(borrower_code);
            txts.Add(borrower_phone);
            txts.Add(borrower_rank);
            return txts;
        }
        public void fill_borrow(DATA_AL.borrow borrow)
        {
            if (borrow.br_id != 0)
            {
                convert_color_black(re_borrow());
                borrow_id.Text = borrow.br_id.ToString();
                cmb_borrower_code.Text = borrow.borrower.bwr_code;
                DATA_AL.book book_ = BL.table_opration.Many_book_borrow.get_borrow_books(borrow.br_id)[0];
                book.SelectedIndex = book.FindStringExact(book_.bk_name);
                cmb_book_id.Text = book_.bk_id.ToString();
                borrower.SelectedIndex = borrower.FindStringExact(borrow.borrower.bwr_name);

            }
        }
        public List<TextBox> re_borrow()
        {
            List<TextBox> txts = new List<TextBox>();
            txts.Add(borrow_id);
            return txts;
        }
        public void convert_color_black(List<TextBox> txts)
        {
            foreach (TextBox txt in txts)
            {
                txt.ForeColor = Color.White;
            }
        }
        public void convert_color_gray(List<TextBox> txts)
        {
            foreach (TextBox txt in txts)
            {
                txt.ForeColor = Color.Gray;
            }
        }
        private void book_grid_SelectionChanged(object sender, EventArgs e)
        {
            DATA_AL.book book = new DATA_AL.book();
            foreach (DataGridViewRow row in book_grid.SelectedRows)
            {
                book = BL.table_opration.book.search(Convert.ToInt32(row.Cells[0].Value));
            }
            fill_book(book);
        }

        private void borrow_datagrid_SelectionChanged(object sender, EventArgs e)
        {
            DATA_AL.borrow borrow = new DATA_AL.borrow();
            foreach (DataGridViewRow row in borrow_datagrid.SelectedRows)
            {
                borrow = BL.table_opration.borrow.search_id(Convert.ToInt32(row.Cells[0].Value));
            }
            fill_borrow(borrow);
        }

        private void borrower_datagrid_SelectionChanged(object sender, EventArgs e)
        {
            DATA_AL.borrower borrower = new DATA_AL.borrower();
            foreach (DataGridViewRow row in borrower_datagrid.SelectedRows)
            {
                borrower = BL.table_opration.borrower.search(Convert.ToInt32(row.Cells[0].Value));
            }
            fill_borrower(borrower);
        }

        private void publisher_datagrid_SelectionChanged(object sender, EventArgs e)
        {
            DATA_AL.publisher publisher = new DATA_AL.publisher();
            foreach (DataGridViewRow row in publisher_datagrid.SelectedRows)
            {
                publisher = BL.table_opration.publisher.search_id(Convert.ToInt32(row.Cells[0].Value));
            }
            fill_publisher(publisher);
        }

        private void author_datagrid_SelectionChanged(object sender, EventArgs e)
        {
            DATA_AL.author author = new DATA_AL.author();
            foreach (DataGridViewRow row in author_datagrid.SelectedRows)
            {
                author = BL.table_opration.author.search(Convert.ToInt32(row.Cells[0].Value));
            }
            fill_author(author);
        }

        private void category_datagrid_SelectionChanged(object sender, EventArgs e)
        {
            DATA_AL.categorie categorie = new DATA_AL.categorie();
            foreach (DataGridViewRow row in category_datagrid.SelectedRows)
            {
                categorie = BL.table_opration.categorie.search(Convert.ToInt32(row.Cells[0].Value));
            }
            fill_categorie(categorie);
        }
        public bool bool_book()
        {
            bool right = true;
            foreach (TextBox txt in re_book())
            {
                if (txt.Name == txt.Text)
                {
                    if (txt.Name != book_id.Name)
                        return false;
                }
            }
            if (publisher.SelectedIndex == -1 || category.SelectedIndex == -1 || author.SelectedIndex == -1)
                return false;
            return right;

        }
        public bool bool_borrow()
        {
            bool right = true;

            if (book.SelectedIndex == -1 || borrower.SelectedIndex == -1)
                return false;
            return right;

        }
        public bool bool_borrower()
        {
            bool right = true;
            foreach (TextBox txt in re_borrower())
            {
                if (txt.Name == txt.Text)
                {
                    if (txt.Name != borrower_id.Name)
                        return false;
                }
            }
            return right;

        }
        public bool bool_author()
        {
            bool right = true;
            foreach (TextBox txt in re_author())
            {
                if (txt.Name == txt.Text)
                {
                    if (txt.Name != author_id.Name)
                        return false;
                }
            }
            return right;

        }
        public bool bool_category()
        {
            bool right = true;
            foreach (TextBox txt in re_categore())
            {
                if (txt.Name == txt.Text)
                {
                    if (txt.Name != category_id.Name)
                        return false;
                }
            }
            return right;

        }
        public bool bool_publisher()
        {
            bool right = true;
            foreach (TextBox txt in re_publisher())
            {
                if (txt.Name == txt.Text)
                {
                    if (txt.Name != publisher_id.Name)
                        return false;
                }
            }
            return right;

        }
        public void limit_size_txt(List<TextBox> list)
        {
            foreach (TextBox txt in list)
            {
                txt.MaxLength = 60;
            }
        }

        private void borrower_phone_TextChanged(object sender, EventArgs e)
        {
            BL.handle.handle_int_txt(sender, 11);
        }

        private void languge_TextChanged(object sender, EventArgs e)
        {
            BL.handle.handle_text_change_to_name(sender);
        }


        private void book_note_Enter(object sender, EventArgs e)
        {
          
            if ((book_note).Text == "")
            {
                book_note.Text = book_note.Name;
                book_note.ForeColor = Color.Gray;
            }
            else if (book_note.Text == book_note.Name)
            {
                book_note.Text = "";
                book_note.ForeColor = Color.White;
            }
        }

        private void book_note_Leave(object sender, EventArgs e)
        {
           
            if ((book_note).Text == "")
            {
                book_note.Text = book_note.Name;
                book_note.ForeColor = Color.Gray;
            }
            else if (book_note.Text == book_note.Name)
            {
                book_note.Text = "";
                book_note.ForeColor = Color.White;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // Process.Start("F:\\mine\\Help File3.docx");
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           // Process.Start("F:\\mine\\Help File3.docx");
        }

        private void button20_MouseHover(object sender, EventArgs e)
        {
            button20.BackColor = Color.Red;
        }

        private void button20_MouseLeave(object sender, EventArgs e)
        {
            button20.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button17_MouseHover(object sender, EventArgs e)
        {
            button17.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void button17_MouseLeave(object sender, EventArgs e)
        {
            button17.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button33_MouseHover(object sender, EventArgs e)
        {
            button33.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void button33_MouseLeave(object sender, EventArgs e)
        {
            button33.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button32_MouseHover(object sender, EventArgs e)
        {
            button32.BackColor = Color.FromArgb(20, 25, 72);
        }

        private void button32_MouseLeave(object sender, EventArgs e)
        {
            button32.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button31_MouseHover(object sender, EventArgs e)
        {
            //button31.BackColor = Color.FromArgb(20, 25, 72);
        }

        private void button31_MouseLeave(object sender, EventArgs e)
        {
            //button31.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button30_MouseHover(object sender, EventArgs e)
        {
            //button30.BackColor = Color.FromArgb(20, 25, 72);
        }

        private void button30_MouseLeave(object sender, EventArgs e)
        {
            //button30.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button29_MouseHover(object sender, EventArgs e)
        {
            button29.BackColor = Color.FromArgb(20, 25, 72);
        }

        private void button29_MouseLeave(object sender, EventArgs e)
        {
            button29.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            book_grid.DataSource = BL.table_view.book.Convert_to_books_views(BL.table_opration.book.search(textBox1.Text));
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            category_datagrid.DataSource = BL.table_view.category.Convert_to_categorys_views(BL.table_opration.categorie.search(textBox6.Text));
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           author_datagrid.DataSource = BL.table_view.author.Convert_to_authors_views(BL.table_opration.author.search(textBox5.Text));
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            publisher_datagrid.DataSource = BL.table_view.publisher.Convert_to_publishers_views(BL.table_opration.publisher.search_name(textBox4.Text));
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            borrower_datagrid.DataSource = BL.table_view.borrower.Convert_to_borrowers_views(BL.table_opration.borrower.search_name(textBox3.Text));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            borrow_datagrid.DataSource = BL.table_view.borrow.Convert_to_borrows_views(BL.table_opration.borrow.search(textBox2.Text));
        }

        private void tabControl1_MouseEnter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            tooltip.Show(txt.Name, txt, 7000);
        }

        private void book_note_MouseEnter(object sender, EventArgs e)
        {
            RichTextBox txt = (RichTextBox)sender;
            tooltip.Show(txt.Name, txt, 7000);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Menu_control f1 = new Menu_control();
            f1.Show();
            this.Hide();
        }

        private void button31_Click_1(object sender, EventArgs e)
        {
            Menu_control f1 = new Menu_control();
            f1.Show();
            this.Hide();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Menu_control f1 = new Menu_control();
            f1.Show();
            this.Hide();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Menu_control f1 = new Menu_control();
            f1.Show();
            this.Hide();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Menu_control f1 = new Menu_control();
            f1.Show();
            this.Hide();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Menu_control f1 = new Menu_control();
            f1.Show();
            this.Hide();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            

        }

        private void button39_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Form3 f2 = new Form3();
            f2.Show();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Form4 f2 = new Form4();
            f2.Show();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Form5 f2 = new Form5();
            f2.Show();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Form6 f2 = new Form6();
            f2.Show();
        }
    }
}

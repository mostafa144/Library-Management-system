using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.BL
{
    class handle
    {
        public static void handle_float_txt(object sender, int size)
        {
            TextBox txt = sender as TextBox;
            txt.MaxLength = size;
            if (txt.Text != txt.Name)
            {
                if (txt.Text != "")
                {
                    if (char.IsDigit(txt.Text.Last()) || (txt.Text.Last() == '.'))
                    {
                        if (txt.Text.Last() == '.')
                        {

                            string needle = ".";
                            int needleCount = (txt.Text.Length - txt.Text.Replace(needle, "").Length) / needle.Length;
                            if (needleCount > 1)
                            { txt.Text = txt.Text.Remove(txt.Text.Length - 1); }
                        }
                    }
                    else
                    {
                        txt.Text = txt.Text.Remove(txt.Text.Length - 1);
                    }
                    for (int x = 0; x < txt.Text.Length;)
                    {
                        if (!(char.IsDigit(txt.Text[x])) && txt.Text[x] != '.')
                        {

                            txt.Text = txt.Text.Remove(x, 1);
                            x--;
                        }

                        string needle = ".";
                        int needleCount = (txt.Text.Length - txt.Text.Replace(needle, "").Length) / needle.Length;
                        if (needleCount > 1)
                        {
                            x++;
                            if (txt.Text[x]=='.')
                            {
                                txt.Text = txt.Text.Remove(x, 1); 
                            }
                            x--;
                        }
                            x++;
                    }
                }
            }
        }
        public static void handle_int_txt(object sender, int size)
        {
            TextBox txt = sender as TextBox;
            txt.MaxLength = size;
            if (txt.Text == txt.Name)
            { }
            else
            {
                if (txt.Text != "")
                {
                    if (char.IsDigit(txt.Text.Last()))
                    { }
                    else
                    {
                        txt.Text = txt.Text.Remove(txt.Text.Length - 1);
                    }
                    for (int x = 0; x < txt.Text.Length;)
                    {
                        if (!(char.IsDigit(txt.Text[x])))
                        {
                            txt.Text = txt.Text.Remove(x, 1);
                            x--;

                        }
                        x++;

                    }
                }
            }
        }
        public static void focus( Form b,int page,string name)
        {
           
            Control ctn = b.Controls["tabControl1"];
            TabControl tab = (TabControl)ctn;
            tab.SelectedIndex = page;
            GroupBox gro = tab.TabPages[page].Controls.Find("groupBox_"+page.ToString(), true)[0] as GroupBox;
            TextBox txt1=null;
            foreach (Control tb in gro.Controls)
            {
                if (tb is TextBox)
                {
                    if (tb.Name == name)
                    {
                        txt1 = (TextBox)tb;
                        break;
                    }
                }
            }
            if ((txt1).Text == "")
            {
                txt1.Text = txt1.Name;
                txt1.ForeColor = Color.Gray;
            }
            else if (txt1.Text == txt1.Name)
            {
                txt1.Text = "";
                txt1.ForeColor = Color.Black;
            }
        }
       public static bool txt_focus_work = false;
        public static void focus(object sender)
        {
            txt_focus_work = true;
            TextBox txt1 = sender as TextBox;
            if ((txt1).Text == "")
            {
                txt1.Text = txt1.Name;
                txt1.ForeColor = Color.Gray;
            }
            else if (txt1.Text == txt1.Name)
            {
                txt1.Text = "";
                txt1.ForeColor = Color.White;
            }
            txt_focus_work = false;
        }
        public static bool make_txt_sure(List<TextBox> tx_li)
        {
            bool sur = true;
            for (int x = 0; x < tx_li.Count; x++)
                if (tx_li[x].Name == tx_li[x].Text)
                    sur = false;
            return sur;
        }
        public static void handle_text_change_to_name(object sender)
        {
            if (!txt_focus_work)
            {
                TextBox txt = sender as TextBox;
                if (txt.Name == txt.Text)
                    txt.Text = "none";
            }
        }
    }
}

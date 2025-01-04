using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystemWinForm
{
    public partial class GetBook : Form
    {
        public GetBook()
        {
            InitializeComponent();
        }
        int index_book = 0;
        int index_user = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("فیلد شماره کتاب باید پر شود");

            int code = Convert.ToInt32(textBox1.Text);

            bool flag = false;


            for (; index_book < Form1.bk.Count; index_book++)
            {
                if (code == Form1.bk[index_book].get_code())
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                richTextBox1.Text = Form1.bk[index_book].get_info();
            }
            else
                MessageBox.Show("کتابی با این مشخصات یافت نشد");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool flag = false;
            for (; index_user < Form1.mb.Count; index_user++)
            {
                if (Form1.mb[index_user].get_id() == Convert.ToInt32(textBox2.Text))
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                richTextBox2.Text = Form1.mb[index_user].get_info();
            }
            else
                MessageBox.Show("کاربری با این شماره کاربری یافت نشد");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool flag1 = true, flag2 = true, flag3 = true, flag4 = true, flag5 = true,flag6=true,flag7=true;
            if (textBox1.Text == "")
                flag6 = false;
            if(flag6)
            {
                if (Form1.bk[index_book].get_count() == 0)
                {
                    flag1 = false;
                    MessageBox.Show("موجودی کتاب ناکافی ست");
                }
            }

            if (textBox2.Text == "")
                flag7 = false;
            if(flag7)
            {
                if (Form1.mb[index_user].get_count() == Form1.mb[index_user].get_max_count())
                {
                    flag2 = false;
                    MessageBox.Show("این کاربر حداکثر تعداد کتاب را به امانت گرفته");
                }
            }

            if (textBox3.Text == "" || Convert.ToInt32(textBox3.Text) > 31 || Convert.ToInt32(textBox3.Text) <= 0)
                flag3 = false;
            if (textBox4.Text == "" || Convert.ToInt32(textBox4.Text) > 12 || Convert.ToInt32(textBox4.Text) <= 0)
                flag4 = false;

            if(flag3)
            {
                if (Convert.ToInt32(textBox3.Text) == 31 && Convert.ToInt32(textBox4.Text) > 6)
                    flag4 = false;
            }

            if (textBox5.Text == "" || Convert.ToInt32(textBox5.Text) > 1400 || Convert.ToInt32(textBox5.Text) < 1300)
                flag5 = false;

            if (flag1 && flag2 && flag3 && flag4 && flag5)
            {
                int current_count = Form1.bk[index_book].get_count();
                Form1.bk[index_book].set_count(current_count - 1);

                current_count = Form1.mb[index_user].get_count();
                Form1.mb[index_user].set_count(current_count + 1);

                Borrows b = new Borrows();

                b.set_applicant(Form1.mb[index_user]);
                b.set_book(Form1.bk[index_book]);

                int year = Convert.ToInt32(textBox5.Text);
                int month = Convert.ToInt32(textBox4.Text);
                int day = Convert.ToInt32(textBox3.Text);
                b.set_date(new Date(year, month, day));

                Form1.br.Add(b);

                MessageBox.Show("با موفیقیت ثبت شد");

                new GetBook().ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("فیلد خالی یا نامعتبر");
        }
    }
}

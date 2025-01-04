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
    public partial class EditMember : Form
    {
        public EditMember()
        {
            InitializeComponent();
        }
        int index = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = true;
            for (; index < Form1.mb.Count; index++) 
            {
                if (Form1.mb[index].get_id() == Convert.ToInt32(textBox1.Text))
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
                MessageBox.Show("عضوی با این شماره یافت نشد");
            else
            {
                richTextBox1.Text = Form1.mb[index].get_info();

                label2.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            label3.Text = "نام و نام خانوادگی جدید را وارد کنید";
            textBox2.Visible = true;
            button2.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            label3.Text = "نوع عضویت  جدید را وارد کنید";
            textBox2.Visible = true;
            button2.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            label3.Text = "شماره ملی جدید را وارد کنید";
            textBox2.Visible = true;
            button2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                if (textBox1.Text == "")
                    MessageBox.Show("ورودی نا معتبر");
                else
                {
                    Form1.mb[index].set_name(textBox2.Text);
                    MessageBox.Show("با موفقیت ویرایش شد");

                    new EditMember().ShowDialog();
                    this.Close();
                }

            }

            if (radioButton2.Checked == true)
            {
                if (textBox2.Text == "عادی")
                {
                    Form1.mb[index].set_membership_model("عادی");
                    Form1.mb[index].set_max_count(3);

                    MessageBox.Show("با موفقیت ویرایش شد");

                    new EditMember().ShowDialog();
                    this.Close();
                }

                else if (textBox2.Text == "ویژه")
                {
                    Form1.mb[index].set_membership_model("ویژه");
                    Form1.mb[index].set_max_count(5);

                    MessageBox.Show("با موفقیت ویرایش شد");

                    new EditMember().ShowDialog();
                    this.Close();
                }

                else
                    MessageBox.Show("ورودی نا معتبر");
            }
            if(radioButton3.Checked==true)
            {
                if (textBox2.Text[0] == '-')
                    MessageBox.Show("ورودی نامعتبر");

                else if (textBox2.Text == "")
                    MessageBox.Show("ورودی نامعتبر");

                else if (!new AddMember().is_exsit(textBox2.Text))
                {
                    Form1.mb[index].set_national_code(textBox2.Text);
                    MessageBox.Show("با موفقیت ویرایش شد");

                    new EditMember().ShowDialog();
                    this.Close();
                }

                else
                    MessageBox.Show("این کد ملی در حال حاضر عضو است،کدی دیگر را امتحان کنید");
            }
        }
    }
}

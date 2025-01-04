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
    public partial class EditBook : Form
    {
        public EditBook()
        {
            InitializeComponent();
        }
        int index = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("فیلد شماره کتاب باید پر شود");

            int code = Convert.ToInt32(textBox1.Text);

            bool flag1 = false;


            for (; index<Form1.bk.Count; index++)
            {
                if (code == Form1.bk[index].get_code())
                {
                    flag1 = true;
                    break;
                }
            }
            if (flag1)
            {
                richTextBox1.Text = Form1.bk[index].get_info();
                label2.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
            }
            else
                MessageBox.Show("کتابی با این کد وجود ندارد");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            label3.Text = "نام جدید را وارد کنید";
            textBox2.Visible = true;
            button3.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            label3.Text = "نام نویسنده جدید را وارد کنید";
            textBox2.Visible = true;
            button3.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            label3.Text = "تعداد جدید را وارد کنید";
            textBox2.Visible = true;
            button3.Visible = true;
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            label3.Text = "ناشر جدید را وارد کنید";
            textBox2.Visible = true;
            button3.Visible = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {

            if(radioButton1.Checked==true)
            {
                bool flag = true;

                if (textBox2.Text == "")
                    flag = false;

                if(flag)
                {
                    Form1.bk[index].set_name(textBox2.Text);
                    MessageBox.Show("با موفقیت ویرایش شد");
                    new EditBook().ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("مقدار ورودی نامعتبر");

            }

            if (radioButton2.Checked == true)
            {
                bool flag = true;

                if (textBox2.Text == "")
                    flag = false;

                if (flag)
                {
                    Form1.bk[index].set_writer(textBox2.Text);
                    MessageBox.Show("با موفقیت ویرایش شد");
                    new EditBook().ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("مقدار ورودی نامعتبر");

            }

            if (radioButton3.Checked == true)
            {
                bool flag = true;

                if (textBox2.Text == "")
                    flag = false;
                if (textBox2.Text[0] == '-')
                    flag = false;

                if (flag)
                {
                    Form1.bk[index].set_count(Convert.ToInt32(textBox2.Text));
                    MessageBox.Show("با موفقیت ویرایش شد");
                    new EditBook().ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("مقدار ورودی نامعتبر");

            }

            if (radioButton4.Checked == true)
            {
                bool flag = true;

                if (textBox2.Text == "")
                    flag = false;

                if (flag)
                {
                    Form1.bk[index].set_publisher(textBox2.Text);
                    MessageBox.Show("با موفقیت ویرایش شد");
                    new EditBook().ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("مقدار ورودی نامعتبر");
            }

        }
    }
}

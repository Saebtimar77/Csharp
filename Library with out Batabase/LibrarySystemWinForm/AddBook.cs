using System;
using System.Windows.Forms;

namespace LibrarySystemWinForm
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }
        public bool is_exist(int code)
        {
            if (Form1.bk.Count == 0)
                return false;

            for (int i = 0; i < Form1.bk.Count; i++)
                if (Form1.bk[i].get_code() == code)
                    return true;

            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool flag1 = true, flag2 = true, flag3 = true, flag4 = true, flag5 = true;

            if (textBox1.Text == "")
            {
                flag1 = false;
                MessageBox.Show("نام کتاب باید معلوم باشد");
            }
            if (textBox2.Text == "")
            {
                flag2 = false;
                MessageBox.Show("نام نویسنده باید معلوم باشد");
            }
            if (textBox3.Text == "")
            {
                flag3 = false;
                MessageBox.Show("نام ناشر باید معلوم باشد");
            }
            if (textBox4.Text == "")
            {
                flag4 = false;
                MessageBox.Show("تعداد کتاب باید معلوم باشد");
            }
            if (textBox4.Text[0] == '-')
            {
                flag4 = false;
                MessageBox.Show("مقدار تعداد نامعتبر");
            }
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false
            && radioButton5.Checked == false && radioButton6.Checked == false && radioButton7.Checked == false && radioButton8.Checked == false)
            {
                flag5 = false;
                MessageBox.Show("موضوع کتاب باید مشخص شود");
            }

            if (flag1 && flag2 && flag3 && flag4 && flag5)
            {
                Book b = new Book();

                b.set_name(textBox1.Text);
                b.set_writer(textBox2.Text);
                b.set_publisher(textBox3.Text);
                b.set_count(Convert.ToInt32(textBox4.Text));

                int code;
                while (true)
                {
                    code = new Random().Next(1000, 9999);
                    if (!is_exist(code))
                        break;
                }
                b.set_code(code);

                if (radioButton1.Checked == true)
                    b.set_subject("علمی");
                if (radioButton2.Checked == true)
                    b.set_subject("داستانی");
                if (radioButton3.Checked == true)
                    b.set_subject("رمان");
                if (radioButton4.Checked == true)
                    b.set_subject("درسی");
                if (radioButton5.Checked == true)
                    b.set_subject("مجله");
                if (radioButton6.Checked == true)
                    b.set_subject("مذهبی");
                if (radioButton7.Checked == true)
                    b.set_subject("متفرقه");
                if (radioButton8.Checked == true)
                    b.set_subject("دانستنی");

                Form1.bk.Add(b);

                MessageBox.Show("با موفقیت ثبت شد" + "\n" + "کد کتاب " + code);
                new AddBook().ShowDialog();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
            this.Close();
        }
    }
}

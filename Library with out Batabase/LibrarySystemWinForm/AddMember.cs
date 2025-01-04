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
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }

        public bool is_exsit(string code)
        {
            if (Form1.mb.Count == 0)
                return false;

            for (int i = 0; i < Form1.mb.Count; i++)
                if (Form1.mb[i].get_national_code() == code)
                    return true;

            return false;
        }

        bool is_repeate(int id)
        {
            if (Form1.mb.Count == 0)
                return false;

            for (int i = 0; i < Form1.mb.Count; i++)
                if (Form1.mb[i].get_id() == id)
                    return true;

            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool flag1 = true, flag2 = true, flag3 = true, flag4 = true, flag5 = true, flag6 = true, flag7 = true;

            if (textBox1.Text == "")
                flag1 = false;
            if (textBox2.Text == "")
                flag2 = false;
            if (textBox3.Text == "")
                flag3 = false;
            if (textBox3.Text[0] == '-')
                flag3 = false;
            if (radioButton1.Checked == false && radioButton2.Checked == false)
                flag4 = false;
            if (textBox4.Text == "" || Convert.ToInt32(textBox4.Text) > 31 || Convert.ToInt32(textBox4.Text) <= 0)
                flag5 = false;
            if (textBox5.Text == "" || Convert.ToInt32(textBox5.Text) > 12 || Convert.ToInt32(textBox5.Text) <= 0)
                flag6 = false;
            if (Convert.ToInt32(textBox4.Text) == 31 && Convert.ToInt32(textBox5.Text) > 6)
                flag6 = false;
            if (textBox6.Text == "" || Convert.ToInt32(textBox6.Text) > 1404 || Convert.ToInt32(textBox6.Text) < 1300)
                flag7 = false;

            if (flag1 && flag2 && flag3 && flag4 && flag5 && flag6 && flag7)
            {
                Member m = new Member();

                m.set_name(textBox1.Text);
                m.set_father_name(textBox2.Text);
                m.set_national_code(textBox3.Text);

                if(radioButton1.Checked==true)
                {
                    m.set_membership_model("عادی");
                    m.set_max_count(3);
                }
                if(radioButton2.Checked==true)
                {
                    m.set_membership_model("ویژه");
                    m.set_max_count(5);
                }

                int id;
                while(true)
                {
                    id = new Random().Next(10000, 99999);
                    if (!is_repeate(id))
                        break;
                }
                m.set_id(id);

                int day = Convert.ToInt32(textBox4.Text);
                int month = Convert.ToInt32(textBox5.Text);
                int year = Convert.ToInt32(textBox6.Text);

                m.set_date(new Date(year, month, day));

                Form1.mb.Add(m);

                MessageBox.Show("با موفقیت ثبت شد" + "\n" + "شناسه شما:" + id);

                new AddMember().ShowDialog();
                this.Close();
            }

            else if (is_exsit(textBox3.Text))
                MessageBox.Show("این کد ملی دارای عضویت است");

            else
                MessageBox.Show("فیلد خالی یا ورودی نامعتبر");
        }

        private void AddMember_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

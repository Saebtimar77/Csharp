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
    public partial class BackBook : Form
    {
        public BackBook()
        {
            InitializeComponent();
        }
        int index_user=0;
        private void button3_Click(object sender, EventArgs e)
        {
            bool flag1 = false;
            bool flag2 = false;
            
            for(; index_user<Form1.br.Count; index_user++)
            {
                if (Convert.ToInt32(textBox1.Text) == Form1.br[index_user].get_applicant().get_id())
                {
                    flag1 = true;
                    break;
                }
            }

            if(flag1)
            {
                for (int i = 0; i < Form1.br.Count; i++)
                {
                    if (Form1.br[i].get_applicant().get_id() == Form1.br[index_user].get_applicant().get_id())
                    {
                        flag2 = true;

                        richTextBox1.Text += Form1.br[i].get_book().get_name() + 
                        "\t" + Form1.br[i].get_book().get_code() + "\t" + Form1.br[i].get_date().ToString() + "\n";

                        label2.Visible = true;
                        textBox2.Visible = true;
                        button1.Visible = true;
                    }
                }
            }
            if (!flag2)
                MessageBox.Show("این کاربر کتابی امانت نگرفته");
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int index = 0;
            bool flag1 = true;
            bool flag2 = false;
            if (textBox2.Text == "")
                flag1 = false;

            for (; index< Form1.br.Count; index++) 
            {
                if (Convert.ToInt32(textBox2.Text) == Form1.br[index].get_book().get_code() &&
                    Convert.ToInt32(textBox1.Text) == Form1.br[index].get_applicant().get_id() )
               {
                    flag2 = true;
                    break;
               }
            }
            if (flag1 && flag2) 
            {
                Form1.br[index].change_status();
                for(int i=0; i<Form1.br.Count; i++)
                {
                    bool flag = false;

                    for(int j=0; j<Form1.mb.Count; j++)
                    {
                        if(Form1.mb[j].get_id()==Form1.br[i].get_applicant().get_id())
                        {
                            Form1.mb[j].set_count(Form1.mb[j].get_count() - 1);
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                        break;
                }
                for (int i = 0; i < Form1.br.Count; i++)
                {
                    bool flag = false;

                    for (int j = 0; j < Form1.bk.Count; j++)
                    {
                        if (Form1.bk[j].get_code() == Form1.br[i].get_book().get_code())
                        {
                            Form1.bk[j].set_count(Form1.bk[j].get_count() + 1);
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                        break;
                }
                MessageBox.Show("با موفقیت انجام شد");

                new BackBook().ShowDialog();
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

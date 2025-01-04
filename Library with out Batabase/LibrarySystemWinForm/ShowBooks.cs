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
    public partial class ShowBooks : Form
    {
        public ShowBooks()
        {
            InitializeComponent();
        }

        private void ShowBooks_Load(object sender, EventArgs e)
        {
            if (Form1.bk.Count == 0)
                richTextBox1.Text = "\t\t\t\tرکوردی برای نمایش وجو ندارد";

            for (int i = 0; i < Form1.bk.Count; i++)
                richTextBox1.Text += Form1.bk[i].get_info() + "\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
            this.Close();
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class ShowBorrowBook : Form
    {
        public ShowBorrowBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
            this.Close();
        }

        private void ShowBorrowBook_Load(object sender, EventArgs e)
        {
            if (Form1.br.Count == 0)
                richTextBox1.Text = "\t\t\tرکوردی برای نمایش وجود ندارد";

            for (int i = 0; i < Form1.br.Count; i++) 
            {
                if (Form1.br[i].get_status())
                    continue;
                richTextBox1.Text += Form1.br[i].get_info();
            }
        }
    }
}

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
    public partial class ShowMembers : Form
    {
        public ShowMembers()
        {
            InitializeComponent();
        }

        private void ShowMembers_Load(object sender, EventArgs e)
        {
            if (Form1.mb.Count == 0)
                richTextBox1.Text = "\t\t\t\tرکوردی برای نمایش وجود ندارد";
            for (int i = 0; i < Form1.mb.Count; i++)
                richTextBox1.Text += Form1.mb[i].get_info() + "\n";
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

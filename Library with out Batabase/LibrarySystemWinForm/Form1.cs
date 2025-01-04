using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibrarySystemWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static List<Book> bk = new List<Book>();
        public static List<Member> mb = new List<Member>();
        public static List<Borrows> br = new List<Borrows>();

        private void button1_Click(object sender, EventArgs e)
        {
            new AddBook().ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ShowBooks().ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new EditBook().ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new AddMember().ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new ShowMembers().ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new EditMember().ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new GetBook().ShowDialog();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new ShowBorrowBook().ShowDialog();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new BackBook().ShowDialog();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

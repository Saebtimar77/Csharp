using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_book
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnabstract_Click(object sender, EventArgs e)
        {
            Abstract abs = new Abstract();
            abs.ShowDialog();
            abs.Hide();
            abs.Close();
        }

        private void btnsealed_Click(object sender, EventArgs e)
        {
            Sealed sea = new Sealed();
            sea.ShowDialog();
            sea.Hide();
            sea.Close();
        }

        private void btnpartial_Click(object sender, EventArgs e)
        {
            Partial par = new Partial();
            par.ShowDialog();
            par.Hide();
            par.Close();
        }

        private void btnpoly_Click(object sender, EventArgs e)
        {
            Poly poly = new Poly();
            poly.ShowDialog();
            poly.Hide();
            poly.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soon!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soon!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soon!");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soon!");

        }
    }
}

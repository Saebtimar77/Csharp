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
    public partial class Singnin : Form
    {
        public Singnin()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string user = txtusername.Text;
            string pass = txtpassword.Text;
            Mysql mysql = new Mysql();
            mysql.Loginmember(user,pass);
        }

        private void linkLabelsignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Singnup a = new Singnup();
            this.Hide();
            a.ShowDialog();
            this.Close();
        }
    }
}

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
    public partial class Singnup : Form
    {
        private Mysql sql;
        public Singnup()
        {
            InitializeComponent();
            sql = new Mysql();  

        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            string fullname=txtfullname.Text;
            string phone=txtcallnumber.Text;
            string username=txtusername.Text;
            string password=txtpassword.Text;
            string confirm=txtconfirmpassword.Text;
            
            sql.addmember(fullname,phone,username,password,confirm);
            MessageBox.Show("success");
            
            Singnin singnin = new Singnin();
            this.Hide();
            singnin.ShowDialog();
            this.Close();
            
        }

        private void linkLabellogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Singnin s = new Singnin();
            this.Hide();
            s.ShowDialog();
            this.Close();
        }
    }
}

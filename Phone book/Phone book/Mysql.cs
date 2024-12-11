using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
namespace Phone_book
{
    internal class Mysql
    {
        private OleDbConnection conection;
        public Mysql()
        {
            conection = new OleDbConnection();
        }



        public void addmember(string fullname, string phone, string username, string password, string confirmpassword)
        {

            conection.ConnectionString = "provider=Microsoft.ace.oledb.12.0;data source= Database1.accdb";
            conection.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "INSERT INTO member ([Fullname],Callnumber,[Username],[Password],Confirmpassword) VALUES (@1,@2,@3,@4,@5)";
            cmd.Parameters.AddWithValue("@1", fullname);
            cmd.Parameters.AddWithValue("@2", phone);
            cmd.Parameters.AddWithValue("@3", username);
            cmd.Parameters.AddWithValue("@4", password);
            cmd.Parameters.AddWithValue("@5", confirmpassword);
            cmd.Connection = conection;
            cmd.ExecuteNonQuery();
            conection.Close();
        }

        public void Loginmember(string username, string password)
        {
            conection.ConnectionString = "provider=Microsoft.ace.oledb.12.0;data source= Database1.accdb";
            conection.Open();
            OleDbCommand command = new OleDbCommand();
            command.CommandText = "SELECT COUNT(*) FROM member WHERE [Username]=@1 AND [Password]=@2";
            command.Parameters.AddWithValue("@1", username);
            command.Parameters.AddWithValue("@2", password);
            command.Connection = conection;
            int count = (int)command.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("Welcom to my app");
                Form1 form = new Form1();
                Singnin singnin = new Singnin();
                singnin.Hide();
                form.ShowDialog();
                singnin.Close();
            }
            else
            {
                MessageBox.Show("invalid user or pass");
            }


        }

    }
}

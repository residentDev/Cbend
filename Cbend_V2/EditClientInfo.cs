using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cbend_V2
{
    public partial class EditClientInfo : UserControl
    {
        String name;
        public EditClientInfo(String name)
        {
            InitializeComponent();
            this.name = name;
        }

        private void EditClientInfo_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = GetSqlConnection();
            if (name != "admin")
            {
                CreditLb.Visible = true;
                CreditTxtBox.Visible = true;
                SqlCommand command = new SqlCommand(
              "select name, password, credit from Accounts where name  = @name",
              sqlcon);
                sqlcon.Open();
                command.Parameters.AddWithValue("@name", name);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    NameTxtBox.Text = reader.GetString(0);
                    PasswordTxtBox.Text = reader.GetString(1);
                    CreditTxtBox.Text = reader.GetInt32(2).ToString();

                }
                reader.Close();
                sqlcon.Close();
            }
            else
            {
                SqlCommand command = new SqlCommand(
             "select name, password from Accounts where name  = @name",
             sqlcon);
                sqlcon.Open();
                command.Parameters.AddWithValue("@name", name);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    NameTxtBox.Text = reader.GetString(0);
                    PasswordTxtBox.Text = reader.GetString(1);

                }
                reader.Close();
                sqlcon.Close();
            }
            
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = GetSqlConnection();
            if(name != "admin")
            {
                string query = "update Accounts set name = @name, password = @password, credit = @credit  where name = @Oldname";
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@Oldname", name);
                cmd.Parameters.AddWithValue("@name", NameTxtBox.Text);
                cmd.Parameters.AddWithValue("@password", PasswordTxtBox.Text);
                cmd.Parameters.AddWithValue("@credit", CreditTxtBox.Text);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("non valid credit");
                }
                
                sqlcon.Close();
                MessageBox.Show("Record Updated Successfully");
            }
            else
            {
                string query = "update Accounts set name = @name, password = @password where name = @Oldname";
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@Oldname", name);
                cmd.Parameters.AddWithValue("@name", NameTxtBox.Text);
                cmd.Parameters.AddWithValue("@password", PasswordTxtBox.Text);
                cmd.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("Record Updated Successfully");
            }
            
        }
        public SqlConnection GetSqlConnection()
        {
            String sc = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\WinDocs\Visual Studio 2017\Projects\Cbend_V2\Cbend_V2\Db.mdf;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(sc);
            return sqlcon;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PnlContainer.Controls.Clear();
            MainForm.Instance.PnlContainer.Controls.Add(new AccountsList());
        }
    }
}

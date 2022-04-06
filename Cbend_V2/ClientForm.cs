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
    public partial class ClientForm : UserControl
    {
        public ClientForm()
        {
            InitializeComponent();
        }
        
        //add new user to DB
        private void AddUserBtn_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(UserNameTxtBox.Text) || String.IsNullOrEmpty(PasswdTxtBox.Text))
            {
                MessageBox.Show("Empty fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //gets all names and passwords from Db
                List<string> AccountList = new List<string>();
                SqlConnection sqlcon = GetSqlConnection();
                SqlCommand command = new SqlCommand(
                  "select name, password from Accounts",
                  sqlcon);
                sqlcon.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    AccountList.Add(reader.GetString(0));
                    AccountList.Add(reader.GetString(1));
                }
                reader.Close();
                sqlcon.Close();
                //check for matched Accounts with the provided account
                if (AccountList.Contains(UserNameTxtBox.Text) || AccountList.Contains(PasswdTxtBox.Text))
                {
                    MessageBox.Show("Accounts already existe", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        int Credits = Int32.Parse(CreditsTxtBox.Text);
                        SqlCommand command2 = new SqlCommand(
                        "insert into Accounts (admin, name, password, credit) values(0, @name, @password, @credit)",
                        sqlcon);
                        command2.Parameters.AddWithValue("@name", UserNameTxtBox.Text);
                        command2.Parameters.AddWithValue("@password", PasswdTxtBox.Text);
                        command2.Parameters.AddWithValue("@credit", Credits);
                        sqlcon.Open();
                        command2.ExecuteNonQuery();
                        sqlcon.Close();
                        DialogResult result = MessageBox.Show("operation successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("non valid value for credits");
                    }

                }
            }
           
            
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PnlContainer.Controls.Clear();
            MainForm.Instance.PnlContainer.Controls.Add(new AccountsList());
        }
        public SqlConnection GetSqlConnection()
        {
            String sc = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\WinDocs\Visual Studio 2017\Projects\Cbend_V2\Cbend_V2\Db.mdf;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(sc);
            return sqlcon;
        }
    }

        
    }

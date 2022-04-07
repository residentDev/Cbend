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
    public partial class AdminDashBoard : UserControl
    {
        String name;
        public AdminDashBoard()
        {
            InitializeComponent();
        }

        private void AdminDashBoard_Load(object sender, EventArgs e)
        {
            LoadAccountsList();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = GetSqlConnection();
            if(name != "admin")
            {
                SqlCommand command = new SqlCommand("delete from Accounts where name = @name", sqlcon);
                command.Parameters.AddWithValue("@name", name);
                sqlcon.Open();
                command.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("operation successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AccountsListPanel.Controls.Clear();
                LoadAccountsList();
            }
            else
            {
                SqlCommand command = new SqlCommand("update Accounts set password = NULL where id = 1", sqlcon);
                sqlcon.Open();
                command.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("operation successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        private void ClientBtn_Click(object sender, EventArgs e)
        {
            DeleteBtn.Visible = true;
            UpdateBtn.Visible = true;
            name = (sender as Button).Text;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
           
            MainForm.Instance.PnlContainer.Controls.Clear();
            MainForm.Instance.PnlContainer.Controls.Add(new EditClientInfo(name));

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
        public void LoadAccountsList()
        {
            SqlConnection sqlcon = GetSqlConnection();
            SqlCommand command = new SqlCommand(
              "select name from Accounts",
              sqlcon);
            sqlcon.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Button ClientBtn = new Button();
                ClientBtn.Text = reader.GetString(0);
                AccountsListPanel.Controls.Add(ClientBtn);
                ClientBtn.Click += ClientBtn_Click;
            }
            reader.Close();
            sqlcon.Close();
        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PnlContainer.Controls.Clear();
            MainForm.Instance.PnlContainer.Controls.Add(new ClientForm());
            MainForm.Instance.PnlContainer.Show();
        }
    }
}

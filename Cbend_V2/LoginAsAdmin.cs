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
    public partial class LoginAsAdmin : UserControl
    {
        String ClientName;
        int credit;
        public LoginAsAdmin(String ClientName, int credit)
        {
            InitializeComponent();
            this.ClientName = ClientName;
            this.credit = credit;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            //check if the password match admin password
            string query = "select password from Accounts where password = '" + PasswdTextBox.Text + "'";
            SqlConnection sqlcon = GetSqlConnection();
            sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count > 0)
            {
                MainForm.Instance.PnlContainer.Controls.Clear();
                MainForm.Instance.PnlContainer.Controls.Add(new AddCredits(ClientName));
                
              
            }
            else
            {
                MessageBox.Show("Wrong password", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public SqlConnection GetSqlConnection()
        {
            String sc = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\WinDocs\Visual Studio 2017\Projects\Cbend_V2\Cbend_V2\Db.mdf;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(sc);
            return sqlcon;
        }
        //back to client dashboard
        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PnlContainer.Controls.Clear();
            MainForm.Instance.PnlContainer.Controls.Add(new ClientDashboard(ClientName, credit));
        }
    }
}

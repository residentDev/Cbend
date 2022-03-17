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
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }
        //Set the admin password
        private void SignInBtn_Click(object sender, EventArgs e)
        {
            String sc = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aymen\Documents\Visual Studio 2017\Projects\Cbend_V2\Cbend_V2\Db.mdf;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(sc);
            string query = "update Accounts set password = @password  where id = 1";
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            cmd.Parameters.Add("password", SqlDbType.VarChar).Value = PasswdTextBox.Text;
            cmd.ExecuteNonQuery();
            DialogResult result = MessageBox.Show("operation successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                MainForm.Instance.PnlContainer.Controls.Clear();
                MainForm.Instance.PnlContainer.Controls.Add(new AccountsList());
            }
        }
    }
}

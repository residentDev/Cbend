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
    public partial class AddCredits : UserControl
    {
        String ClientName;
        public AddCredits(String ClientName)
        {
            InitializeComponent();
            this.ClientName = ClientName;
        }

        private void AddCreditBtn_Click(object sender, EventArgs e)
        {
            //get the origenal credit from db
            int OldCredit = 0;
            
            SqlConnection sqlcon = GetSqlConnection();
            SqlCommand command = new SqlCommand(
              "select credit from Accounts where name  = @ClientName",
              sqlcon);
            sqlcon.Open();
            command.Parameters.AddWithValue("@ClientName", ClientName);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                OldCredit = reader.GetInt32(0);

            }
            reader.Close();
            sqlcon.Close();
            // update credit in db
            string query = "update Accounts set  credit = @credit where name = @name";
            int NewCredit = OldCredit + int.Parse(CreditTextBox.Text);
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            cmd.Parameters.AddWithValue("@name", ClientName);
            cmd.Parameters.AddWithValue("@credit", NewCredit.ToString());
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
            MainForm.Instance.PnlContainer.Controls.Clear();
            MainForm.Instance.PnlContainer.Controls.Add(new ClientDashboard(ClientName, NewCredit));
        }
        public SqlConnection GetSqlConnection()
        {
            String sc = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\WinDocs\Visual Studio 2017\Projects\Cbend_V2\Cbend_V2\Db.mdf;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(sc);
            return sqlcon;
        }
    }
}

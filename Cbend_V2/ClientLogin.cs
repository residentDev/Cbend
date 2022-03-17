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
    public partial class ClientLogin : UserControl
    {
        String Clientname;
        public ClientLogin(String Clientname)
        {
            InitializeComponent();
            this.Clientname = Clientname;
        }

   

        //check if user in db
        //load user dashboard
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string query = "select name, password, credit from Accounts where password = '" + PasswdTxtBox.Text + "' and name = '"+Clientname+"'";
            String sc = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aymen\Documents\Visual Studio 2017\Projects\Cbend_V2\Cbend_V2\Db.mdf;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(sc);
            sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count > 0)
            {
                String name = dtbl.Rows[0].Field<String>("name");
                MainForm.Instance.PnlContainer.Controls.Clear();
                if(name != "admin")
                {
                    int credit = dtbl.Rows[0].Field<int>("credit");
                    MainForm.Instance.PnlContainer.Controls.Add(new ClientDashboard(name, credit));
                }
                else
                {
                    MainForm.Instance.PnlContainer.Controls.Add(new AdminDashBoard());
                }
                
            }
            else
            {
                MessageBox.Show("Wrong password", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void PasswdTxtBox_TextChanged(object sender, EventArgs e)
        {
            LoginBtn.Visible = true;
        }
    }
}

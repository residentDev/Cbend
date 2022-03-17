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
    public partial class AccountsList : UserControl
    {
        Button ClientBtn;
        public AccountsList()
        {
            InitializeComponent();
        }

        
        //load Client Form
        private void CreateAccountBtn_Click_1(object sender, EventArgs e)
        {
           MainForm.Instance.PnlContainer.Controls.Clear();
           MainForm.Instance.PnlContainer.Controls.Add(new ClientForm());
           MainForm.Instance.PnlContainer.Show();
        }

        //get list of users accounts on each load
        private void AccountsList_Load(object sender, EventArgs e)
        {
            String sc = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aymen\Documents\Visual Studio 2017\Projects\Cbend_V2\Cbend_V2\Db.mdf;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(sc);
            SqlCommand command = new SqlCommand(
              "select name from Accounts",
              sqlcon);
            sqlcon.Open();
            SqlDataReader reader = command.ExecuteReader();
           
            while (reader.Read())
            {
                ClientBtn = new Button();
                ClientBtn.Text = reader.GetString(0);
                flowLayoutPanel1.Controls.Add(ClientBtn);
                
                ClientBtn.Click += ClientBtn_Click;


            }
            reader.Close();
            sqlcon.Close();
        }
        //load client Login page
        private void ClientBtn_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PnlContainer.Controls.Clear();
            String Clientname = (sender as Button).Text;
            MainForm.Instance.PnlContainer.Controls.Add(new ClientLogin(Clientname));
        }


    }
}

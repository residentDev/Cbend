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
    public partial class ClientDashboard : UserControl
    {
        String name;
        int credit;
        
        public ClientDashboard(String name, int credit)
        {
            InitializeComponent();
            this.name = name;
            this.credit = credit;
        }
        private void ClientDashboard_Load(object sender, EventArgs e)
        {
            UsernameLb.Text = name;
            CreditsLb.Text = credit.ToString();
            switch (credit)
            {
                case 0:
                    BlockStartBtn.Enabled = false;
                    FreeStartBtn.Enabled = false;
                    break;
                case 1:
                    BlockStartBtn.Enabled = false;
                    break;
            }
        }

        private void FreeStartBtn_Click(object sender, EventArgs e)
        {
            
            MainForm.Instance.PnlContainer.Controls.Clear();
            MainForm.Instance.PnlContainer.Controls.Add(new FreeStartUc(name, credit));

        }
        
        //Back to Accounts List
        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PnlContainer.Controls.Clear();
            MainForm.Instance.PnlContainer.Controls.Add(new AccountsList());
        }
        private void BlockStartBtn_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PnlContainer.Controls.Clear();
            MainForm.Instance.PnlContainer.Controls.Add(new BlockStartUc(name, credit));
            
        }
        public SqlConnection GetSqlConnection()
        {
            String sc = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\WinDocs\Visual Studio 2017\Projects\Cbend_V2\Cbend_V2\Db.mdf;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(sc);
            return sqlcon;
        }
        private void AddCreditBtn_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PnlContainer.Controls.Clear();
            MainForm.Instance.PnlContainer.Controls.Add(new LoginAsAdmin(name, credit));
        }
        }
  
}

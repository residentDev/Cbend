using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cbend_V2
{
    public partial class MainForm : Form
    {
        static MainForm _obj;
        public static MainForm Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new MainForm();
                }
                return _obj;
            }
        }
        public Panel PnlContainer
        {
            get { return MainPanel; }
        }
        public MainForm()
        {
            InitializeComponent();
        }

        //check for admin Login when Load event triggerd
        private void MainForm_Load(object sender, EventArgs e)
        {
            _obj = this;
            SqlConnection sqlcon = GetSqlConnection();
            SqlCommand command = new SqlCommand(
              "select password from Accounts where id = 1;",
              sqlcon);
            sqlcon.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    //load accounts List 
                    AccountsList accountsListPage = new AccountsList();
                    MainPanel.Controls.Add(accountsListPage);
                }
                else
                {
                    //load welcome page for admin
                    Welcome welcomePage = new Welcome();
                    MainPanel.Controls.Add(welcomePage);
                }
                
            }
            
        }
        public SqlConnection GetSqlConnection()
        {
            String sc = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\WinDocs\Visual Studio 2017\Projects\Cbend_V2\Cbend_V2\Db.mdf;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(sc);
            return sqlcon;
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

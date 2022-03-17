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
        
        private DateTime startTime;

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
            TimeLb.Text = TimeSpan.FromMinutes(int.Parse(CreditsLb.Text)).ToString(@"mm\:ss");
            

        }

        private void FreeStartBtn_Click(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            timer1.Start();
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLb.Text = (TimeSpan.FromMinutes(int.Parse(CreditsLb.Text)) - (DateTime.Now - startTime)).ToString(@"mm\:ss");
            if (TimeLb.Text == "00:00")
            {
                timer1.Stop();
                MessageBox.Show("ur Time is Up", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                String sc = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aymen\Documents\Visual Studio 2017\Projects\Cbend_V2\Cbend_V2\Db.mdf;Integrated Security=True";
                SqlConnection sqlcon = new SqlConnection(sc);
                string query = "update Accounts set credit = 0  where name = @name";
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.Add("name", SqlDbType.VarChar).Value = UsernameLb.Text;
                cmd.ExecuteNonQuery();
            }
                
        }

        private void ClientDashboard_Leave(object sender, EventArgs e)
        {
            String sc = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aymen\Documents\Visual Studio 2017\Projects\Cbend_V2\Cbend_V2\Db.mdf;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(sc);
            string query = "update Accounts set credit = @credit  where name = @name";
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            cmd.Parameters.Add("name", SqlDbType.VarChar).Value = UsernameLb.Text;
            List<string> LeftTime = TimeLb.Text.Split(':').ToList<string>();
            cmd.Parameters.Add("name", SqlDbType.Variant).Value = int.Parse(LeftTime[0]);
            cmd.ExecuteNonQuery();
        }
    }
}

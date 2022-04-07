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
using System.Threading;

namespace Cbend_V2
{
    public partial class FreeStartUc : UserControl
    {
        String ClientName;
        int Credit;
        public List<string> LeftTimeAfterPausing;
        public TimeSpan ts;
        public DateTime startTime;
        public FreeStartUc(String ClientName, int Credit)
        {
            InitializeComponent();
            this.ClientName = ClientName;
            this.Credit = Credit;
        }

        private void FreeStartUc_Load(object sender, EventArgs e)
        {
            
            ts = TimeSpan.FromMinutes(Credit);
            startTime = DateTime.Now;
            timer1.Start();
            TimerLb.Text = string.Format("{0:00}:{1:00}:{2:00}", (int)(ts - (DateTime.Now - startTime)).TotalHours, (ts - (DateTime.Now - startTime)).Minutes, (ts - (DateTime.Now - startTime)).Seconds);
            ClientNameLb.Text = ClientName;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerLb.Text = string.Format("{0:00}:{1:00}:{2:00}", (int)(ts - (DateTime.Now - startTime)).TotalHours, (ts - (DateTime.Now - startTime)).Minutes, (ts - (DateTime.Now - startTime)).Seconds);
            
            //When time is up
            if (TimerLb.Text == "00:00:00")
            {
                timer1.Stop();
                MessageBox.Show("ur Time is Up", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Credit = 0;
                MainForm.Instance.PnlContainer.Controls.Clear();
                MainForm.Instance.PnlContainer.Controls.Add(new ClientDashboard(ClientName, Credit));
                //update credit in db
                SqlConnection sqlcon = GetSqlConnection();
                string query = "update Accounts set credit = 0  where name = @name";
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.Add("name", SqlDbType.VarChar).Value = ClientNameLb.Text;
                cmd.ExecuteNonQuery();
            }
        }
        public SqlConnection GetSqlConnection()
        {
            String sc = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\WinDocs\Visual Studio 2017\Projects\Cbend_V2\Cbend_V2\Db.mdf;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(sc);
            return sqlcon;
        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            if(PauseBtn.Text == "Pause")
            {
                timer1.Stop();
                LeftTimeAfterPausing = TimerLb.Text.Split(':').ToList<string>();
                //set ts to the pausing time
                ts = new TimeSpan(int.Parse(LeftTimeAfterPausing[0]), int.Parse(LeftTimeAfterPausing[1]), int.Parse(LeftTimeAfterPausing[2]));
                PauseBtn.Text = "Resume";
                AddCreditsBtn.Enabled = true;
            }
            else
            {
                startTime = DateTime.Now;
                timer1.Start();
                PauseBtn.Text = "Pause";
                AddCreditsBtn.Enabled = false;

            }
            
        }

        private void EndBtn_Click(object sender, EventArgs e)
        {
            
            timer1.Stop();
            //set ts to the ending time
            LeftTimeAfterPausing = TimerLb.Text.Split(':').ToList<string>();
            ts = new TimeSpan(int.Parse(LeftTimeAfterPausing[0]), int.Parse(LeftTimeAfterPausing[1]), int.Parse(LeftTimeAfterPausing[2]));
            Credit = (int)ts.TotalMinutes;
            MainForm.Instance.PnlContainer.Controls.Clear();
            MainForm.Instance.PnlContainer.Controls.Add(new ClientDashboard(ClientName, Credit));
            SqlConnection sqlcon = GetSqlConnection();
            string query = "update Accounts set credit = @credit  where name = @name";
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            cmd.Parameters.Add("name", SqlDbType.VarChar).Value = ClientNameLb.Text;
            cmd.Parameters.Add("credit", SqlDbType.Int).Value = Credit;
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        private void AddCredits_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PnlContainer.Controls.Clear();
            MainForm.Instance.PnlContainer.Controls.Add(new LoginAsAdmin(ClientName, Credit));
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            //set ts to the ending time
            LeftTimeAfterPausing = TimerLb.Text.Split(':').ToList<string>();
            ts = new TimeSpan(int.Parse(LeftTimeAfterPausing[0]), int.Parse(LeftTimeAfterPausing[1]), int.Parse(LeftTimeAfterPausing[2]));
            Credit = (int)ts.TotalMinutes;
            MainForm.Instance.PnlContainer.Controls.Clear();
            MainForm.Instance.PnlContainer.Controls.Add(new ClientDashboard(ClientName, Credit));
            SqlConnection sqlcon = GetSqlConnection();
            string query = "update Accounts set credit = @credit  where name = @name";
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            cmd.Parameters.Add("name", SqlDbType.VarChar).Value = ClientNameLb.Text;
            cmd.Parameters.Add("credit", SqlDbType.Int).Value = Credit;
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }
    }
}

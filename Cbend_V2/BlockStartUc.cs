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
    public partial class BlockStartUc : UserControl
    {
        String ClientName;
        int Credit;
        public List<string> LeftTimeAfterPausing;
        public TimeSpan ts;
        public DateTime startTime;
        public Decimal OldValueOfSpinBox;
        public String OldValueOfCreditLb;
        public BlockStartUc(String ClientName, int Credit)
        {
            InitializeComponent();
            this.ClientName = ClientName;
            this.Credit = Credit;
        }

        private void BlockStartUc_Load(object sender, EventArgs e)
        {
            ts = TimeSpan.FromMinutes((int)numericUpDown.Value);
            TimerLb.Text = string.Format("{0:00}:{1:00}:{2:00}", (int)ts.TotalHours, ts.Minutes, ts.Seconds);
            ClientNameLb.Text = ClientName;
            CreditsLb.Text = (Credit - 1).ToString();
            OldValueOfCreditLb = CreditsLb.Text;
            OldValueOfSpinBox = numericUpDown.Value;
            if (Credit % 2 > 0)
            {
                //set the max value of numericUpDown to half + 1
                numericUpDown.Maximum = (int)(Credit / 2) + 1;
            }
            //case of odd peer
            else
            {
                //set the max value of numericUpDown to half
                numericUpDown.Maximum = (int)(Credit / 2);
            }
            
        }
        
        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            //update timer label when ever the numericaUpDown value change
            ts = TimeSpan.FromMinutes((int)numericUpDown.Value);
            TimerLb.Text = string.Format("{0:00}:{1:00}:{2:00}", (int)ts.TotalHours, ts.Minutes, ts.Seconds);
            if (numericUpDown.Value > OldValueOfSpinBox)
            {
                ///value increased, handle accordingly
                CreditsLb.Text = (int.Parse(OldValueOfCreditLb) - 1).ToString();
                OldValueOfSpinBox = numericUpDown.Value;
                OldValueOfCreditLb = CreditsLb.Text;
            }
            else if (numericUpDown.Value < OldValueOfSpinBox)
            {
                ///value decreased, handle accordingly
                CreditsLb.Text = (int.Parse(OldValueOfCreditLb) + 1).ToString();
                OldValueOfSpinBox = numericUpDown.Value;
                OldValueOfCreditLb = CreditsLb.Text;
            }
            else
            {
                return;
            }
            //OldValue = numericUpDown.Value;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if(StartBtn.Text == "Start")
            {
                startTime = DateTime.Now;
                timer1.Start();
                StartBtn.Text = "Pause";
                numericUpDown.Visible = false;
                AddCredits.Enabled = false;
            }
            else if(StartBtn.Text == "Pause")
            {
                timer1.Stop();
                LeftTimeAfterPausing = TimerLb.Text.Split(':').ToList<string>();
                //set ts to the pausing time
                ts = new TimeSpan(int.Parse(LeftTimeAfterPausing[0]), int.Parse(LeftTimeAfterPausing[1]), int.Parse(LeftTimeAfterPausing[2]));           
                StartBtn.Text = "Resume";
                AddCredits.Enabled = true;
            }
            else
            {
                
                startTime = DateTime.Now;
                timer1.Start();
                StartBtn.Text = "Pause";
                AddCredits.Enabled = false;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerLb.Text = string.Format("{0:00}:{1:00}:{2:00}", (int)(ts - (DateTime.Now - startTime)).TotalHours, (ts - (DateTime.Now - startTime)).Minutes, (ts - (DateTime.Now - startTime)).Seconds);

            //When time is up
            if (TimerLb.Text == "00:00:00")
            {
                timer1.Stop();
                MessageBox.Show("ur Time is Up", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Credit = Credit - (int)numericUpDown.Value;
                MainForm.Instance.PnlContainer.Controls.Clear();
                MainForm.Instance.PnlContainer.Controls.Add(new ClientDashboard(ClientName, Credit));
                //update credit in db
                SqlConnection sqlcon = GetSqlConnection();
                string query = "update Accounts set credit = @credit  where name = @name";
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.Add("name", SqlDbType.VarChar).Value = ClientNameLb.Text;
                cmd.Parameters.Add("credit", SqlDbType.Int).Value = Credit;
                cmd.ExecuteNonQuery();
            }
        }
        public SqlConnection GetSqlConnection()
        {
            String sc = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\WinDocs\Visual Studio 2017\Projects\Cbend_V2\Cbend_V2\Db.mdf;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(sc);
            return sqlcon;
        }

        private void EndBtn_Click(object sender, EventArgs e)
        {
            
            //set ts to the difference between credit and numericUpDown Value
            timer1.Stop();
            LeftTimeAfterPausing = TimerLb.Text.Split(':').ToList<string>();
            if (LeftTimeAfterPausing[1] == "00")
            {
                Credit = Credit - 1;
                CreditsLb.Text = Credit.ToString();
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
            else
            {
                
                Credit = Credit - (int)numericUpDown.Value;
                CreditsLb.Text = Credit.ToString();
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

        private void AddCredits_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PnlContainer.Controls.Clear();
            MainForm.Instance.PnlContainer.Controls.Add(new LoginAsAdmin(ClientName, Credit));
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            LeftTimeAfterPausing = TimerLb.Text.Split(':').ToList<string>();
            Credit = Credit - (int)numericUpDown.Value;
            CreditsLb.Text = Credit.ToString();
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

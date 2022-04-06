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
        List<string> LeftTimeAfterPausing;
        TimeSpan ts;
        Boolean isBlockBtnClicked = false;
        Boolean isFreeStartBtnClicked = false;


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
            ts = TimeSpan.FromMinutes(credit);
            //set timer lable from credit
            TimeLb.Text = string.Format("{0:00}:{1:00}:{2:00}", (int)ts.TotalHours, ts.Minutes, ts.Seconds);
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
            isFreeStartBtnClicked = true;
            //update ui
            PauseBtn.Visible = true;
            EndBtn.Visible = true;
            BlockStartBtn.Enabled = false;
            AddCreditBtn.Enabled = false;
            startTime = DateTime.Now;
            timer1.Start();
           
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLb.Text = string.Format("{0:00}:{1:00}:{2:00}", (int)(ts - (DateTime.Now - startTime)).TotalHours, (ts - (DateTime.Now - startTime)).Minutes, (ts - (DateTime.Now - startTime)).Seconds);
            //When time is up
            if (TimeLb.Text == "00:00:00")
            {
                timer1.Stop();
                //update ui
                FreeStartBtn.Enabled = true;
                BlockStartBtn.Enabled = true;
                StartBtn.Visible = false;
                PauseBtn.Visible = false;
                EndBtn.Visible = false;
                AddCreditBtn.Enabled = true;
                isBlockBtnClicked = false;
                isFreeStartBtnClicked = false;
                MessageBox.Show("ur Time is Up", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //update credit in db
                SqlConnection sqlcon = GetSqlConnection();
                string query = "update Accounts set credit = 0  where name = @name";
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.Add("name", SqlDbType.VarChar).Value = UsernameLb.Text;
                cmd.ExecuteNonQuery();
            }
                
        }

        private void ClientDashboard_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
            //case of Block start
            if (isBlockBtnClicked)
            {
                //calculate the left time
                //update the credit in db
                List<string> LeftTime = TimeLb.Text.Split(':').ToList<string>();
                ts = new TimeSpan(int.Parse(LeftTime[0]), int.Parse(LeftTime[1]), int.Parse(LeftTime[2]));
                int LeftCreditFromBlockStart = (int)numericUpDown.Value - (int)ts.TotalMinutes;
                int NewCredit = credit - LeftCreditFromBlockStart;
                SqlConnection sqlcon = GetSqlConnection();
                string query = "update Accounts set credit = @credit  where name = @name";
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.Add("name", SqlDbType.VarChar).Value = UsernameLb.Text;
                cmd.Parameters.Add("credit", SqlDbType.Int).Value = NewCredit;
                cmd.ExecuteNonQuery();
                sqlcon.Close();
                isBlockBtnClicked = false;
                isFreeStartBtnClicked = false;
            }
            //case of Free start
            else if (isFreeStartBtnClicked)
            {
                //update the credit in db
                SqlConnection sqlcon = GetSqlConnection();
                string query = "update Accounts set credit = @credit  where name = @name";
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.Add("name", SqlDbType.VarChar).Value = UsernameLb.Text;
                List<string> LeftTime = TimeLb.Text.Split(':').ToList<string>();
                ts = new TimeSpan(int.Parse(LeftTime[0]), int.Parse(LeftTime[1]), int.Parse(LeftTime[2]));
                cmd.Parameters.Add("credit", SqlDbType.Int).Value = ts.TotalMinutes;
                cmd.ExecuteNonQuery();
                sqlcon.Close();
                isBlockBtnClicked = false;
                isFreeStartBtnClicked = false;
            }
           
        }
        //Back to Accounts List
        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PnlContainer.Controls.Clear();
            MainForm.Instance.PnlContainer.Controls.Add(new AccountsList());
            isBlockBtnClicked = false;
            isFreeStartBtnClicked = false;
        }
        private void BlockStartBtn_Click(object sender, EventArgs e)
        {
            isBlockBtnClicked = true;
            //update the ui
            numericUpDown.Visible = true;
            StartBtn.Visible = true;
            FreeStartBtn.Enabled = false;
            AddCreditBtn.Enabled = false;
            //numericUpDown.Maximum = (int)(credit / 2);
            //case of odd credit
            if (credit % 2 > 0)
            {
                //set the max value of numericUpDown to half + 1
                numericUpDown.Maximum = (int)(credit / 2) + 1;
                //update timer lable from numericUpDown
                ts = TimeSpan.FromMinutes((int)numericUpDown.Value);
                TimeLb.Text = string.Format("{0:00}:{1:00}:{2:00}", (int)ts.TotalHours, ts.Minutes, ts.Seconds);
            }
            //case of odd peer
            else
            {
                //set the max value of numericUpDown to half
                numericUpDown.Maximum = (int)(credit / 2);
                ts = TimeSpan.FromMinutes((int)numericUpDown.Value);
                TimeLb.Text = string.Format("{0:00}:{1:00}:{2:00}", (int)ts.TotalHours, ts.Minutes, ts.Seconds);
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
            timer1.Stop();
            LeftTimeAfterPausing = TimeLb.Text.Split(':').ToList<string>();
            //set ts to the pausing time
            ts = new TimeSpan(int.Parse(LeftTimeAfterPausing[0]), int.Parse(LeftTimeAfterPausing[1]), int.Parse(LeftTimeAfterPausing[2]));
            StartBtn.Enabled = true;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            timer1.Start();
            PauseBtn.Visible = true;
            EndBtn.Visible = true;
            numericUpDown.Visible = false;
            FreeStartBtn.Enabled = false;
            BlockStartBtn.Enabled = false;
            StartBtn.Visible = false;
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            //update timer label when ever the numericaUpDown value change
            ts = TimeSpan.FromMinutes((int)numericUpDown.Value);
            TimeLb.Text = string.Format("{0:00}:{1:00}:{2:00}", (int)ts.TotalHours, ts.Minutes, ts.Seconds);

        }
        private void AddCreditBtn_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PnlContainer.Controls.Clear();
            MainForm.Instance.PnlContainer.Controls.Add(new LoginAsAdmin(name, credit));
            isBlockBtnClicked = false;
            isFreeStartBtnClicked = false;
        }

        private void EndBtn_Click(object sender, EventArgs e)
        {
            if (isFreeStartBtnClicked)
            {
                timer1.Stop();
                //set ts to the ending time
                LeftTimeAfterPausing = TimeLb.Text.Split(':').ToList<string>();
                ts = new TimeSpan(int.Parse(LeftTimeAfterPausing[0]), int.Parse(LeftTimeAfterPausing[1]), int.Parse(LeftTimeAfterPausing[2]));
                int NewCredit = (int)ts.TotalMinutes;
                //update ui
                CreditsLb.Text = NewCredit.ToString();
                TimeLb.Text = "00:00:00";
                PauseBtn.Visible = false;
                EndBtn.Visible = false;
                BlockStartBtn.Enabled = true;
                FreeStartBtn.Enabled = true;
                SqlConnection sqlcon = GetSqlConnection();
                string query = "update Accounts set credit = @credit  where name = @name";
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.Add("name", SqlDbType.VarChar).Value = UsernameLb.Text;
                cmd.Parameters.Add("credit", SqlDbType.Int).Value = NewCredit;
                cmd.ExecuteNonQuery();
                sqlcon.Close();
                isBlockBtnClicked = false;
                isFreeStartBtnClicked = false;

            }
            else if(isBlockBtnClicked)
            {
                //set ts to the difference between credit and numericUpDown Value
                timer1.Stop();
                LeftTimeAfterPausing = TimeLb.Text.Split(':').ToList<string>();
                if(LeftTimeAfterPausing[1] == "00")
                {
                    int NewCredit = credit - 1;
                    CreditsLb.Text = NewCredit.ToString();
                    TimeLb.Text = "00:00:00";
                    PauseBtn.Visible = false;
                    EndBtn.Visible = false;
                    BlockStartBtn.Enabled = true;
                    FreeStartBtn.Enabled = true;
                    SqlConnection sqlcon = GetSqlConnection();
                    string query = "update Accounts set credit = @credit  where name = @name";
                    sqlcon.Open();
                    SqlCommand cmd = new SqlCommand(query, sqlcon);
                    cmd.Parameters.Add("name", SqlDbType.VarChar).Value = UsernameLb.Text;
                    cmd.Parameters.Add("credit", SqlDbType.Int).Value = NewCredit;
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();
                    isBlockBtnClicked = false;
                    isFreeStartBtnClicked = false;
                }
                else
                {
                    ts = new TimeSpan(int.Parse(LeftTimeAfterPausing[0]), int.Parse(LeftTimeAfterPausing[1]), int.Parse(LeftTimeAfterPausing[2]));
                    int NewCredit = credit - (int)numericUpDown.Value;
                    CreditsLb.Text = NewCredit.ToString();
                    TimeLb.Text = "00:00:00";
                    PauseBtn.Visible = false;
                    EndBtn.Visible = false;
                    BlockStartBtn.Enabled = true;
                    FreeStartBtn.Enabled = true;
                    SqlConnection sqlcon = GetSqlConnection();
                    string query = "update Accounts set credit = @credit  where name = @name";
                    sqlcon.Open();
                    SqlCommand cmd = new SqlCommand(query, sqlcon);
                    cmd.Parameters.Add("name", SqlDbType.VarChar).Value = UsernameLb.Text;
                    cmd.Parameters.Add("credit", SqlDbType.Int).Value = NewCredit;
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();
                    isBlockBtnClicked = false;
                    isFreeStartBtnClicked = false;
                }
                

            }

        }
    }
}

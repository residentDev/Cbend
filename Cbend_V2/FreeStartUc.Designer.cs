namespace Cbend_V2
{
    partial class FreeStartUc
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PauseBtn = new System.Windows.Forms.Button();
            this.EndBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimerLb = new System.Windows.Forms.Label();
            this.ClientNameLb = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.AddCreditsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PauseBtn
            // 
            this.PauseBtn.Location = new System.Drawing.Point(241, 79);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(75, 23);
            this.PauseBtn.TabIndex = 0;
            this.PauseBtn.Text = "Pause";
            this.PauseBtn.UseVisualStyleBackColor = true;
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // EndBtn
            // 
            this.EndBtn.Location = new System.Drawing.Point(241, 140);
            this.EndBtn.Name = "EndBtn";
            this.EndBtn.Size = new System.Drawing.Size(75, 23);
            this.EndBtn.TabIndex = 1;
            this.EndBtn.Text = "End";
            this.EndBtn.UseVisualStyleBackColor = true;
            this.EndBtn.Click += new System.EventHandler(this.EndBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimerLb
            // 
            this.TimerLb.AutoSize = true;
            this.TimerLb.Location = new System.Drawing.Point(73, 111);
            this.TimerLb.Name = "TimerLb";
            this.TimerLb.Size = new System.Drawing.Size(45, 13);
            this.TimerLb.TabIndex = 2;
            this.TimerLb.Text = "TimerLb";
            // 
            // ClientNameLb
            // 
            this.ClientNameLb.AutoSize = true;
            this.ClientNameLb.Location = new System.Drawing.Point(241, 18);
            this.ClientNameLb.Name = "ClientNameLb";
            this.ClientNameLb.Size = new System.Drawing.Size(35, 13);
            this.ClientNameLb.TabIndex = 3;
            this.ClientNameLb.Text = "label1";
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(14, 17);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 4;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // AddCreditsBtn
            // 
            this.AddCreditsBtn.Enabled = false;
            this.AddCreditsBtn.Location = new System.Drawing.Point(118, 17);
            this.AddCreditsBtn.Name = "AddCreditsBtn";
            this.AddCreditsBtn.Size = new System.Drawing.Size(75, 23);
            this.AddCreditsBtn.TabIndex = 5;
            this.AddCreditsBtn.Text = "Add Credits";
            this.AddCreditsBtn.UseVisualStyleBackColor = true;
            this.AddCreditsBtn.Click += new System.EventHandler(this.AddCredits_Click);
            // 
            // FreeStartUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddCreditsBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ClientNameLb);
            this.Controls.Add(this.TimerLb);
            this.Controls.Add(this.EndBtn);
            this.Controls.Add(this.PauseBtn);
            this.Name = "FreeStartUc";
            this.Size = new System.Drawing.Size(381, 260);
            this.Load += new System.EventHandler(this.FreeStartUc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PauseBtn;
        private System.Windows.Forms.Button EndBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TimerLb;
        private System.Windows.Forms.Label ClientNameLb;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button AddCreditsBtn;
    }
}

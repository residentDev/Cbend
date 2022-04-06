namespace Cbend_V2
{
    partial class ClientDashboard
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
            this.FreeStartBtn = new System.Windows.Forms.Button();
            this.BlockStartBtn = new System.Windows.Forms.Button();
            this.CreditsLb = new System.Windows.Forms.Label();
            this.UsernameLb = new System.Windows.Forms.Label();
            this.TimeLb = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BackBtn = new System.Windows.Forms.Button();
            this.PauseBtn = new System.Windows.Forms.Button();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.StartBtn = new System.Windows.Forms.Button();
            this.AddCreditBtn = new System.Windows.Forms.Button();
            this.EndBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // FreeStartBtn
            // 
            this.FreeStartBtn.Location = new System.Drawing.Point(243, 79);
            this.FreeStartBtn.Name = "FreeStartBtn";
            this.FreeStartBtn.Size = new System.Drawing.Size(75, 23);
            this.FreeStartBtn.TabIndex = 0;
            this.FreeStartBtn.Text = "Free Start";
            this.FreeStartBtn.UseVisualStyleBackColor = true;
            this.FreeStartBtn.Click += new System.EventHandler(this.FreeStartBtn_Click);
            // 
            // BlockStartBtn
            // 
            this.BlockStartBtn.Location = new System.Drawing.Point(243, 132);
            this.BlockStartBtn.Name = "BlockStartBtn";
            this.BlockStartBtn.Size = new System.Drawing.Size(75, 23);
            this.BlockStartBtn.TabIndex = 1;
            this.BlockStartBtn.Text = "Block Start";
            this.BlockStartBtn.UseVisualStyleBackColor = true;
            this.BlockStartBtn.Click += new System.EventHandler(this.BlockStartBtn_Click);
            // 
            // CreditsLb
            // 
            this.CreditsLb.AutoSize = true;
            this.CreditsLb.Location = new System.Drawing.Point(279, 23);
            this.CreditsLb.Name = "CreditsLb";
            this.CreditsLb.Size = new System.Drawing.Size(39, 13);
            this.CreditsLb.TabIndex = 2;
            this.CreditsLb.Text = "Credits";
            // 
            // UsernameLb
            // 
            this.UsernameLb.AutoSize = true;
            this.UsernameLb.Location = new System.Drawing.Point(219, 23);
            this.UsernameLb.Name = "UsernameLb";
            this.UsernameLb.Size = new System.Drawing.Size(58, 13);
            this.UsernameLb.TabIndex = 3;
            this.UsernameLb.Text = "User name";
            // 
            // TimeLb
            // 
            this.TimeLb.AutoSize = true;
            this.TimeLb.Location = new System.Drawing.Point(53, 89);
            this.TimeLb.Name = "TimeLb";
            this.TimeLb.Size = new System.Drawing.Size(35, 13);
            this.TimeLb.TabIndex = 4;
            this.TimeLb.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(13, 13);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 5;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // PauseBtn
            // 
            this.PauseBtn.Location = new System.Drawing.Point(243, 191);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(75, 23);
            this.PauseBtn.TabIndex = 6;
            this.PauseBtn.Text = "Pause";
            this.PauseBtn.UseVisualStyleBackColor = true;
            this.PauseBtn.Visible = false;
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(159, 135);
            this.numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown.TabIndex = 8;
            this.numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.Visible = false;
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(130, 191);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 9;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Visible = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // AddCreditBtn
            // 
            this.AddCreditBtn.Location = new System.Drawing.Point(118, 13);
            this.AddCreditBtn.Name = "AddCreditBtn";
            this.AddCreditBtn.Size = new System.Drawing.Size(75, 23);
            this.AddCreditBtn.TabIndex = 10;
            this.AddCreditBtn.Text = "Add Credit";
            this.AddCreditBtn.UseVisualStyleBackColor = true;
            this.AddCreditBtn.Click += new System.EventHandler(this.AddCreditBtn_Click);
            // 
            // EndBtn
            // 
            this.EndBtn.Location = new System.Drawing.Point(243, 253);
            this.EndBtn.Name = "EndBtn";
            this.EndBtn.Size = new System.Drawing.Size(75, 23);
            this.EndBtn.TabIndex = 11;
            this.EndBtn.Text = "End";
            this.EndBtn.UseVisualStyleBackColor = true;
            this.EndBtn.Visible = false;
            this.EndBtn.Click += new System.EventHandler(this.EndBtn_Click);
            // 
            // ClientDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EndBtn);
            this.Controls.Add(this.AddCreditBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.PauseBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.TimeLb);
            this.Controls.Add(this.UsernameLb);
            this.Controls.Add(this.CreditsLb);
            this.Controls.Add(this.BlockStartBtn);
            this.Controls.Add(this.FreeStartBtn);
            this.Name = "ClientDashboard";
            this.Size = new System.Drawing.Size(426, 301);
            this.Load += new System.EventHandler(this.ClientDashboard_Load);
            this.Leave += new System.EventHandler(this.ClientDashboard_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FreeStartBtn;
        private System.Windows.Forms.Button BlockStartBtn;
        private System.Windows.Forms.Label CreditsLb;
        private System.Windows.Forms.Label UsernameLb;
        private System.Windows.Forms.Label TimeLb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button PauseBtn;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button AddCreditBtn;
        private System.Windows.Forms.Button EndBtn;
    }
}

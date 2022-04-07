namespace Cbend_V2
{
    partial class BlockStartUc
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
            this.AddCredits = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.ClientNameLb = new System.Windows.Forms.Label();
            this.TimerLb = new System.Windows.Forms.Label();
            this.EndBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CreditsLb = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // AddCredits
            // 
            this.AddCredits.Location = new System.Drawing.Point(134, 44);
            this.AddCredits.Name = "AddCredits";
            this.AddCredits.Size = new System.Drawing.Size(75, 23);
            this.AddCredits.TabIndex = 11;
            this.AddCredits.Text = "Add Credits";
            this.AddCredits.UseVisualStyleBackColor = true;
            this.AddCredits.Click += new System.EventHandler(this.AddCredits_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(30, 44);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 10;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ClientNameLb
            // 
            this.ClientNameLb.AutoSize = true;
            this.ClientNameLb.Location = new System.Drawing.Point(257, 45);
            this.ClientNameLb.Name = "ClientNameLb";
            this.ClientNameLb.Size = new System.Drawing.Size(35, 13);
            this.ClientNameLb.TabIndex = 9;
            this.ClientNameLb.Text = "label1";
            // 
            // TimerLb
            // 
            this.TimerLb.AutoSize = true;
            this.TimerLb.Location = new System.Drawing.Point(89, 138);
            this.TimerLb.Name = "TimerLb";
            this.TimerLb.Size = new System.Drawing.Size(45, 13);
            this.TimerLb.TabIndex = 8;
            this.TimerLb.Text = "TimerLb";
            // 
            // EndBtn
            // 
            this.EndBtn.Location = new System.Drawing.Point(257, 167);
            this.EndBtn.Name = "EndBtn";
            this.EndBtn.Size = new System.Drawing.Size(75, 23);
            this.EndBtn.TabIndex = 7;
            this.EndBtn.Text = "End";
            this.EndBtn.UseVisualStyleBackColor = true;
            this.EndBtn.Click += new System.EventHandler(this.EndBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(257, 106);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 6;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CreditsLb
            // 
            this.CreditsLb.AutoSize = true;
            this.CreditsLb.Location = new System.Drawing.Point(328, 45);
            this.CreditsLb.Name = "CreditsLb";
            this.CreditsLb.Size = new System.Drawing.Size(35, 13);
            this.CreditsLb.TabIndex = 12;
            this.CreditsLb.Text = "label1";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(188, 106);
            this.numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown.TabIndex = 13;
            this.numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // BlockStartUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.CreditsLb);
            this.Controls.Add(this.AddCredits);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ClientNameLb);
            this.Controls.Add(this.TimerLb);
            this.Controls.Add(this.EndBtn);
            this.Controls.Add(this.StartBtn);
            this.Name = "BlockStartUc";
            this.Size = new System.Drawing.Size(379, 257);
            this.Load += new System.EventHandler(this.BlockStartUc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddCredits;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label ClientNameLb;
        private System.Windows.Forms.Label TimerLb;
        private System.Windows.Forms.Button EndBtn;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label CreditsLb;
        private System.Windows.Forms.NumericUpDown numericUpDown;
    }
}

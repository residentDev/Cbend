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
            this.SuspendLayout();
            // 
            // FreeStartBtn
            // 
            this.FreeStartBtn.Location = new System.Drawing.Point(231, 80);
            this.FreeStartBtn.Name = "FreeStartBtn";
            this.FreeStartBtn.Size = new System.Drawing.Size(75, 23);
            this.FreeStartBtn.TabIndex = 0;
            this.FreeStartBtn.Text = "Free Start";
            this.FreeStartBtn.UseVisualStyleBackColor = true;
            this.FreeStartBtn.Click += new System.EventHandler(this.FreeStartBtn_Click);
            // 
            // BlockStartBtn
            // 
            this.BlockStartBtn.Location = new System.Drawing.Point(231, 136);
            this.BlockStartBtn.Name = "BlockStartBtn";
            this.BlockStartBtn.Size = new System.Drawing.Size(75, 23);
            this.BlockStartBtn.TabIndex = 1;
            this.BlockStartBtn.Text = "Block Start";
            this.BlockStartBtn.UseVisualStyleBackColor = true;
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
            // ClientDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TimeLb);
            this.Controls.Add(this.UsernameLb);
            this.Controls.Add(this.CreditsLb);
            this.Controls.Add(this.BlockStartBtn);
            this.Controls.Add(this.FreeStartBtn);
            this.Name = "ClientDashboard";
            this.Size = new System.Drawing.Size(343, 247);
            this.Load += new System.EventHandler(this.ClientDashboard_Load);
            this.Leave += new System.EventHandler(this.ClientDashboard_Leave);
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
    }
}

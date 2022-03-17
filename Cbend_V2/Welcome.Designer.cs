namespace Cbend_V2
{
    partial class Welcome
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
            this.label1 = new System.Windows.Forms.Label();
            this.TitelLB = new System.Windows.Forms.Label();
            this.SetUpBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "you should set up \r\nan admin account\r\n";
            // 
            // TitelLB
            // 
            this.TitelLB.AutoSize = true;
            this.TitelLB.Location = new System.Drawing.Point(107, 92);
            this.TitelLB.Name = "TitelLB";
            this.TitelLB.Size = new System.Drawing.Size(38, 13);
            this.TitelLB.TabIndex = 7;
            this.TitelLB.Text = "Cbend";
            // 
            // SetUpBtn
            // 
            this.SetUpBtn.Location = new System.Drawing.Point(238, 137);
            this.SetUpBtn.Name = "SetUpBtn";
            this.SetUpBtn.Size = new System.Drawing.Size(146, 58);
            this.SetUpBtn.TabIndex = 6;
            this.SetUpBtn.Text = "Set up here";
            this.SetUpBtn.UseVisualStyleBackColor = true;
            this.SetUpBtn.Click += new System.EventHandler(this.SetUpBtn_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitelLB);
            this.Controls.Add(this.SetUpBtn);
            this.Name = "Welcome";
            this.Size = new System.Drawing.Size(463, 265);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TitelLB;
        private System.Windows.Forms.Button SetUpBtn;
    }
}

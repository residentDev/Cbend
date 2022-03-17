namespace Cbend_V2
{
    partial class Login
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
            this.PasswdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TitelLB = new System.Windows.Forms.Label();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PasswdTextBox
            // 
            this.PasswdTextBox.Location = new System.Drawing.Point(209, 84);
            this.PasswdTextBox.Name = "PasswdTextBox";
            this.PasswdTextBox.Size = new System.Drawing.Size(146, 20);
            this.PasswdTextBox.TabIndex = 13;
            this.PasswdTextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Secure the admin \r\naccount by a password\r\n";
            // 
            // TitelLB
            // 
            this.TitelLB.AutoSize = true;
            this.TitelLB.Location = new System.Drawing.Point(78, 92);
            this.TitelLB.Name = "TitelLB";
            this.TitelLB.Size = new System.Drawing.Size(38, 13);
            this.TitelLB.TabIndex = 11;
            this.TitelLB.Text = "Cbend";
            // 
            // SignInBtn
            // 
            this.SignInBtn.Location = new System.Drawing.Point(209, 137);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(146, 58);
            this.SignInBtn.TabIndex = 10;
            this.SignInBtn.Text = "Sign in";
            this.SignInBtn.UseVisualStyleBackColor = true;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PasswdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitelLB);
            this.Controls.Add(this.SignInBtn);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(419, 279);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PasswdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TitelLB;
        private System.Windows.Forms.Button SignInBtn;
    }
}

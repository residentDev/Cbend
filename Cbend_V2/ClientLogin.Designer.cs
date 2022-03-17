namespace Cbend_V2
{
    partial class ClientLogin
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
            this.PasswdTxtBox = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PasswdTxtBox
            // 
            this.PasswdTxtBox.Location = new System.Drawing.Point(93, 122);
            this.PasswdTxtBox.Name = "PasswdTxtBox";
            this.PasswdTxtBox.Size = new System.Drawing.Size(147, 20);
            this.PasswdTxtBox.TabIndex = 0;
            this.PasswdTxtBox.UseSystemPasswordChar = true;
            this.PasswdTxtBox.TextChanged += new System.EventHandler(this.PasswdTxtBox_TextChanged);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(119, 178);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 1;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Visible = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            // 
            // ClientLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswdTxtBox);
            this.Name = "ClientLogin";
            this.Size = new System.Drawing.Size(327, 270);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PasswdTxtBox;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label label1;
    }
}

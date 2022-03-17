namespace Cbend_V2
{
    partial class EditClientInfo
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
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.CreditTxtBox = new System.Windows.Forms.TextBox();
            this.NameLb = new System.Windows.Forms.Label();
            this.PasswdLb = new System.Windows.Forms.Label();
            this.CreditLb = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(128, 50);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(114, 20);
            this.NameTxtBox.TabIndex = 0;
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.Location = new System.Drawing.Point(128, 95);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.Size = new System.Drawing.Size(114, 20);
            this.PasswordTxtBox.TabIndex = 1;
            // 
            // CreditTxtBox
            // 
            this.CreditTxtBox.Location = new System.Drawing.Point(128, 141);
            this.CreditTxtBox.Name = "CreditTxtBox";
            this.CreditTxtBox.Size = new System.Drawing.Size(114, 20);
            this.CreditTxtBox.TabIndex = 2;
            this.CreditTxtBox.Visible = false;
            // 
            // NameLb
            // 
            this.NameLb.AutoSize = true;
            this.NameLb.Location = new System.Drawing.Point(22, 50);
            this.NameLb.Name = "NameLb";
            this.NameLb.Size = new System.Drawing.Size(33, 13);
            this.NameLb.TabIndex = 3;
            this.NameLb.Text = "name";
            // 
            // PasswdLb
            // 
            this.PasswdLb.AutoSize = true;
            this.PasswdLb.Location = new System.Drawing.Point(22, 102);
            this.PasswdLb.Name = "PasswdLb";
            this.PasswdLb.Size = new System.Drawing.Size(52, 13);
            this.PasswdLb.TabIndex = 4;
            this.PasswdLb.Text = "password";
            // 
            // CreditLb
            // 
            this.CreditLb.AutoSize = true;
            this.CreditLb.Location = new System.Drawing.Point(22, 148);
            this.CreditLb.Name = "CreditLb";
            this.CreditLb.Size = new System.Drawing.Size(33, 13);
            this.CreditLb.TabIndex = 5;
            this.CreditLb.Text = "credit";
            this.CreditLb.Visible = false;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(104, 191);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // EditClientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CreditLb);
            this.Controls.Add(this.PasswdLb);
            this.Controls.Add(this.NameLb);
            this.Controls.Add(this.CreditTxtBox);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.NameTxtBox);
            this.Name = "EditClientInfo";
            this.Size = new System.Drawing.Size(291, 238);
            this.Load += new System.EventHandler(this.EditClientInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.TextBox CreditTxtBox;
        private System.Windows.Forms.Label NameLb;
        private System.Windows.Forms.Label PasswdLb;
        private System.Windows.Forms.Label CreditLb;
        private System.Windows.Forms.Button SaveBtn;
    }
}

namespace Cbend_V2
{
    partial class ClientForm
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
            this.Usernam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserNameTxtBox = new System.Windows.Forms.TextBox();
            this.PasswdTxtBox = new System.Windows.Forms.TextBox();
            this.CreditsTxtBox = new System.Windows.Forms.TextBox();
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Usernam
            // 
            this.Usernam.AutoSize = true;
            this.Usernam.Location = new System.Drawing.Point(80, 69);
            this.Usernam.Name = "Usernam";
            this.Usernam.Size = new System.Drawing.Size(55, 13);
            this.Usernam.TabIndex = 0;
            this.Usernam.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Credits";
            // 
            // UserNameTxtBox
            // 
            this.UserNameTxtBox.Location = new System.Drawing.Point(167, 69);
            this.UserNameTxtBox.MaxLength = 10;
            this.UserNameTxtBox.Name = "UserNameTxtBox";
            this.UserNameTxtBox.Size = new System.Drawing.Size(130, 20);
            this.UserNameTxtBox.TabIndex = 3;
            // 
            // PasswdTxtBox
            // 
            this.PasswdTxtBox.Location = new System.Drawing.Point(167, 120);
            this.PasswdTxtBox.MaxLength = 10;
            this.PasswdTxtBox.Name = "PasswdTxtBox";
            this.PasswdTxtBox.Size = new System.Drawing.Size(130, 20);
            this.PasswdTxtBox.TabIndex = 4;
            this.PasswdTxtBox.UseSystemPasswordChar = true;
            // 
            // CreditsTxtBox
            // 
            this.CreditsTxtBox.Location = new System.Drawing.Point(167, 174);
            this.CreditsTxtBox.MaxLength = 8;
            this.CreditsTxtBox.Name = "CreditsTxtBox";
            this.CreditsTxtBox.Size = new System.Drawing.Size(130, 20);
            this.CreditsTxtBox.TabIndex = 5;
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Location = new System.Drawing.Point(126, 227);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(127, 23);
            this.AddUserBtn.TabIndex = 6;
            this.AddUserBtn.Text = "Add User";
            this.AddUserBtn.UseVisualStyleBackColor = true;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click_1);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(30, 21);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 7;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.AddUserBtn);
            this.Controls.Add(this.CreditsTxtBox);
            this.Controls.Add(this.PasswdTxtBox);
            this.Controls.Add(this.UserNameTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Usernam);
            this.Name = "ClientForm";
            this.Size = new System.Drawing.Size(404, 310);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Usernam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserNameTxtBox;
        private System.Windows.Forms.TextBox PasswdTxtBox;
        private System.Windows.Forms.TextBox CreditsTxtBox;
        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.Button BackBtn;
    }
}

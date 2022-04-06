namespace Cbend_V2
{
    partial class AddCredits
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
            this.AddCreditBtn = new System.Windows.Forms.Button();
            this.CreditTextBox = new System.Windows.Forms.TextBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddCreditBtn
            // 
            this.AddCreditBtn.Location = new System.Drawing.Point(144, 135);
            this.AddCreditBtn.Name = "AddCreditBtn";
            this.AddCreditBtn.Size = new System.Drawing.Size(75, 23);
            this.AddCreditBtn.TabIndex = 0;
            this.AddCreditBtn.Text = "Add";
            this.AddCreditBtn.UseVisualStyleBackColor = true;
            this.AddCreditBtn.Click += new System.EventHandler(this.AddCreditBtn_Click);
            // 
            // CreditTextBox
            // 
            this.CreditTextBox.Location = new System.Drawing.Point(116, 71);
            this.CreditTextBox.MaxLength = 8;
            this.CreditTextBox.Name = "CreditTextBox";
            this.CreditTextBox.Size = new System.Drawing.Size(145, 20);
            this.CreditTextBox.TabIndex = 1;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(19, 22);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 2;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // AddCredits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.CreditTextBox);
            this.Controls.Add(this.AddCreditBtn);
            this.Name = "AddCredits";
            this.Size = new System.Drawing.Size(399, 241);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddCreditBtn;
        private System.Windows.Forms.TextBox CreditTextBox;
        private System.Windows.Forms.Button BackBtn;
    }
}

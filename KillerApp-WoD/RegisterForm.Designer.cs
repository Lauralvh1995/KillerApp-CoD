namespace KillerApp_WoD
{
    partial class RegisterForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbName = new System.Windows.Forms.Label();
            this.lbEMail = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.tBoxEMail = new System.Windows.Forms.TextBox();
            this.tBoxPassword = new System.Windows.Forms.TextBox();
            this.tBoxConfirmPWord = new System.Windows.Forms.TextBox();
            this.lbConfirmPWord = new System.Windows.Forms.Label();
            this.tbConfirmEMail = new System.Windows.Forms.TextBox();
            this.lbConfirmEMail = new System.Windows.Forms.Label();
            this.btSendRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(125, 35);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(49, 17);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Naam:";
            // 
            // lbEMail
            // 
            this.lbEMail.AutoSize = true;
            this.lbEMail.Location = new System.Drawing.Point(125, 63);
            this.lbEMail.Name = "lbEMail";
            this.lbEMail.Size = new System.Drawing.Size(51, 17);
            this.lbEMail.TabIndex = 1;
            this.lbEMail.Text = "E-Mail:";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(86, 119);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(90, 17);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Wachtwoord:";
            // 
            // tBoxName
            // 
            this.tBoxName.Location = new System.Drawing.Point(182, 32);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(137, 22);
            this.tBoxName.TabIndex = 3;
            // 
            // tBoxEMail
            // 
            this.tBoxEMail.Location = new System.Drawing.Point(182, 60);
            this.tBoxEMail.Name = "tBoxEMail";
            this.tBoxEMail.Size = new System.Drawing.Size(137, 22);
            this.tBoxEMail.TabIndex = 4;
            // 
            // tBoxPassword
            // 
            this.tBoxPassword.Location = new System.Drawing.Point(182, 116);
            this.tBoxPassword.Name = "tBoxPassword";
            this.tBoxPassword.PasswordChar = '*';
            this.tBoxPassword.Size = new System.Drawing.Size(137, 22);
            this.tBoxPassword.TabIndex = 5;
            // 
            // tBoxConfirmPWord
            // 
            this.tBoxConfirmPWord.Location = new System.Drawing.Point(182, 144);
            this.tBoxConfirmPWord.Name = "tBoxConfirmPWord";
            this.tBoxConfirmPWord.PasswordChar = '*';
            this.tBoxConfirmPWord.Size = new System.Drawing.Size(137, 22);
            this.tBoxConfirmPWord.TabIndex = 7;
            // 
            // lbConfirmPWord
            // 
            this.lbConfirmPWord.AutoSize = true;
            this.lbConfirmPWord.Location = new System.Drawing.Point(16, 147);
            this.lbConfirmPWord.Name = "lbConfirmPWord";
            this.lbConfirmPWord.Size = new System.Drawing.Size(160, 17);
            this.lbConfirmPWord.TabIndex = 6;
            this.lbConfirmPWord.Text = "Controleer Wachtwoord:";
            // 
            // tbConfirmEMail
            // 
            this.tbConfirmEMail.Location = new System.Drawing.Point(182, 88);
            this.tbConfirmEMail.Name = "tbConfirmEMail";
            this.tbConfirmEMail.Size = new System.Drawing.Size(137, 22);
            this.tbConfirmEMail.TabIndex = 9;
            // 
            // lbConfirmEMail
            // 
            this.lbConfirmEMail.AutoSize = true;
            this.lbConfirmEMail.Location = new System.Drawing.Point(55, 91);
            this.lbConfirmEMail.Name = "lbConfirmEMail";
            this.lbConfirmEMail.Size = new System.Drawing.Size(121, 17);
            this.lbConfirmEMail.TabIndex = 8;
            this.lbConfirmEMail.Text = "Controleer E-Mail:";
            // 
            // btSendRegister
            // 
            this.btSendRegister.Location = new System.Drawing.Point(160, 188);
            this.btSendRegister.Name = "btSendRegister";
            this.btSendRegister.Size = new System.Drawing.Size(75, 23);
            this.btSendRegister.TabIndex = 10;
            this.btSendRegister.Text = "Verstuur!";
            this.btSendRegister.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 233);
            this.Controls.Add(this.btSendRegister);
            this.Controls.Add(this.tbConfirmEMail);
            this.Controls.Add(this.lbConfirmEMail);
            this.Controls.Add(this.tBoxConfirmPWord);
            this.Controls.Add(this.lbConfirmPWord);
            this.Controls.Add(this.tBoxPassword);
            this.Controls.Add(this.tBoxEMail);
            this.Controls.Add(this.tBoxName);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbEMail);
            this.Controls.Add(this.lbName);
            this.Name = "RegisterForm";
            this.Text = "Registreren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbEMail;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.TextBox tBoxEMail;
        private System.Windows.Forms.TextBox tBoxPassword;
        private System.Windows.Forms.TextBox tBoxConfirmPWord;
        private System.Windows.Forms.Label lbConfirmPWord;
        private System.Windows.Forms.TextBox tbConfirmEMail;
        private System.Windows.Forms.Label lbConfirmEMail;
        private System.Windows.Forms.Button btSendRegister;
    }
}
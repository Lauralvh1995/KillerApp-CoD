namespace KillerApp_WoD
{
    partial class LoginForm
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
            this.lbCharBuilder = new System.Windows.Forms.Label();
            this.lbEMail = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tBoxEMail = new System.Windows.Forms.TextBox();
            this.tBoxPassword = new System.Windows.Forms.TextBox();
            this.btLogIn = new System.Windows.Forms.Button();
            this.lbNoAccount = new System.Windows.Forms.Label();
            this.btRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCharBuilder
            // 
            this.lbCharBuilder.AutoSize = true;
            this.lbCharBuilder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCharBuilder.Location = new System.Drawing.Point(38, 9);
            this.lbCharBuilder.Name = "lbCharBuilder";
            this.lbCharBuilder.Size = new System.Drawing.Size(378, 117);
            this.lbCharBuilder.TabIndex = 0;
            this.lbCharBuilder.Text = "Welkom bij de \r\nChronicles of Darkness \r\nCharacter Builder";
            this.lbCharBuilder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbEMail
            // 
            this.lbEMail.AutoSize = true;
            this.lbEMail.Location = new System.Drawing.Point(45, 144);
            this.lbEMail.Name = "lbEMail";
            this.lbEMail.Size = new System.Drawing.Size(51, 17);
            this.lbEMail.TabIndex = 1;
            this.lbEMail.Text = "E-Mail:";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(7, 175);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(90, 17);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Wachtwoord:";
            // 
            // tBoxEMail
            // 
            this.tBoxEMail.Location = new System.Drawing.Point(103, 144);
            this.tBoxEMail.Name = "tBoxEMail";
            this.tBoxEMail.Size = new System.Drawing.Size(288, 22);
            this.tBoxEMail.TabIndex = 3;
            // 
            // tBoxPassword
            // 
            this.tBoxPassword.Location = new System.Drawing.Point(103, 172);
            this.tBoxPassword.Name = "tBoxPassword";
            this.tBoxPassword.PasswordChar = '*';
            this.tBoxPassword.Size = new System.Drawing.Size(288, 22);
            this.tBoxPassword.TabIndex = 4;
            // 
            // btLogIn
            // 
            this.btLogIn.Location = new System.Drawing.Point(194, 201);
            this.btLogIn.Name = "btLogIn";
            this.btLogIn.Size = new System.Drawing.Size(75, 29);
            this.btLogIn.TabIndex = 5;
            this.btLogIn.Text = "Log In";
            this.btLogIn.UseVisualStyleBackColor = true;
            this.btLogIn.Click += new System.EventHandler(this.btLogIn_Click);
            // 
            // lbNoAccount
            // 
            this.lbNoAccount.AutoSize = true;
            this.lbNoAccount.Location = new System.Drawing.Point(95, 266);
            this.lbNoAccount.Name = "lbNoAccount";
            this.lbNoAccount.Size = new System.Drawing.Size(132, 17);
            this.lbNoAccount.TabIndex = 6;
            this.lbNoAccount.Text = "Nog geen account?";
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(233, 261);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(91, 26);
            this.btRegister.TabIndex = 7;
            this.btRegister.Text = "Registreer!";
            this.btRegister.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 304);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.lbNoAccount);
            this.Controls.Add(this.btLogIn);
            this.Controls.Add(this.tBoxPassword);
            this.Controls.Add(this.tBoxEMail);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbEMail);
            this.Controls.Add(this.lbCharBuilder);
            this.Name = "LoginForm";
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCharBuilder;
        private System.Windows.Forms.Label lbEMail;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tBoxEMail;
        private System.Windows.Forms.TextBox tBoxPassword;
        private System.Windows.Forms.Button btLogIn;
        private System.Windows.Forms.Label lbNoAccount;
        private System.Windows.Forms.Button btRegister;
    }
}


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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btSendRegister = new System.Windows.Forms.Button();
            this.tBoxConfirmEMail = new System.Windows.Forms.TextBox();
            this.lbConfirmEMail = new System.Windows.Forms.Label();
            this.tBoxConfirmPWord = new System.Windows.Forms.TextBox();
            this.lbConfirmPWord = new System.Windows.Forms.Label();
            this.tBoxRegisterPassword = new System.Windows.Forms.TextBox();
            this.tBoxRegisterEmail = new System.Windows.Forms.TextBox();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.lbEMail.Location = new System.Drawing.Point(52, 54);
            this.lbEMail.Name = "lbEMail";
            this.lbEMail.Size = new System.Drawing.Size(51, 17);
            this.lbEMail.TabIndex = 1;
            this.lbEMail.Text = "E-Mail:";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(14, 85);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(90, 17);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Wachtwoord:";
            // 
            // tBoxEMail
            // 
            this.tBoxEMail.Location = new System.Drawing.Point(110, 54);
            this.tBoxEMail.Name = "tBoxEMail";
            this.tBoxEMail.Size = new System.Drawing.Size(288, 22);
            this.tBoxEMail.TabIndex = 3;
            // 
            // tBoxPassword
            // 
            this.tBoxPassword.Location = new System.Drawing.Point(110, 82);
            this.tBoxPassword.Name = "tBoxPassword";
            this.tBoxPassword.PasswordChar = '*';
            this.tBoxPassword.Size = new System.Drawing.Size(288, 22);
            this.tBoxPassword.TabIndex = 4;
            // 
            // btLogIn
            // 
            this.btLogIn.Location = new System.Drawing.Point(201, 111);
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
            this.lbNoAccount.Location = new System.Drawing.Point(102, 176);
            this.lbNoAccount.Name = "lbNoAccount";
            this.lbNoAccount.Size = new System.Drawing.Size(132, 17);
            this.lbNoAccount.TabIndex = 6;
            this.lbNoAccount.Text = "Nog geen account?";
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(240, 171);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(91, 26);
            this.btRegister.TabIndex = 7;
            this.btRegister.Text = "Registreer!";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tBoxEMail);
            this.groupBox1.Controls.Add(this.btRegister);
            this.groupBox1.Controls.Add(this.lbEMail);
            this.groupBox1.Controls.Add(this.lbNoAccount);
            this.groupBox1.Controls.Add(this.lbPassword);
            this.groupBox1.Controls.Add(this.btLogIn);
            this.groupBox1.Controls.Add(this.tBoxPassword);
            this.groupBox1.Location = new System.Drawing.Point(12, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 211);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log In";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btSendRegister);
            this.groupBox2.Controls.Add(this.tBoxConfirmEMail);
            this.groupBox2.Controls.Add(this.lbConfirmEMail);
            this.groupBox2.Controls.Add(this.tBoxConfirmPWord);
            this.groupBox2.Controls.Add(this.lbConfirmPWord);
            this.groupBox2.Controls.Add(this.tBoxRegisterPassword);
            this.groupBox2.Controls.Add(this.tBoxRegisterEmail);
            this.groupBox2.Controls.Add(this.tBoxName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbName);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 215);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registreren";
            this.groupBox2.Visible = false;
            // 
            // btSendRegister
            // 
            this.btSendRegister.Location = new System.Drawing.Point(188, 187);
            this.btSendRegister.Name = "btSendRegister";
            this.btSendRegister.Size = new System.Drawing.Size(75, 23);
            this.btSendRegister.TabIndex = 21;
            this.btSendRegister.Text = "Verstuur!";
            this.btSendRegister.UseVisualStyleBackColor = true;
            this.btSendRegister.Click += new System.EventHandler(this.btSendRegister_Click);
            // 
            // tBoxConfirmEMail
            // 
            this.tBoxConfirmEMail.Location = new System.Drawing.Point(210, 87);
            this.tBoxConfirmEMail.Name = "tBoxConfirmEMail";
            this.tBoxConfirmEMail.Size = new System.Drawing.Size(137, 22);
            this.tBoxConfirmEMail.TabIndex = 20;
            // 
            // lbConfirmEMail
            // 
            this.lbConfirmEMail.AutoSize = true;
            this.lbConfirmEMail.Location = new System.Drawing.Point(83, 90);
            this.lbConfirmEMail.Name = "lbConfirmEMail";
            this.lbConfirmEMail.Size = new System.Drawing.Size(121, 17);
            this.lbConfirmEMail.TabIndex = 19;
            this.lbConfirmEMail.Text = "Controleer E-Mail:";
            // 
            // tBoxConfirmPWord
            // 
            this.tBoxConfirmPWord.Location = new System.Drawing.Point(210, 143);
            this.tBoxConfirmPWord.Name = "tBoxConfirmPWord";
            this.tBoxConfirmPWord.PasswordChar = '*';
            this.tBoxConfirmPWord.Size = new System.Drawing.Size(137, 22);
            this.tBoxConfirmPWord.TabIndex = 18;
            // 
            // lbConfirmPWord
            // 
            this.lbConfirmPWord.AutoSize = true;
            this.lbConfirmPWord.Location = new System.Drawing.Point(44, 146);
            this.lbConfirmPWord.Name = "lbConfirmPWord";
            this.lbConfirmPWord.Size = new System.Drawing.Size(160, 17);
            this.lbConfirmPWord.TabIndex = 17;
            this.lbConfirmPWord.Text = "Controleer Wachtwoord:";
            // 
            // tBoxRegisterPassword
            // 
            this.tBoxRegisterPassword.Location = new System.Drawing.Point(210, 115);
            this.tBoxRegisterPassword.Name = "tBoxRegisterPassword";
            this.tBoxRegisterPassword.PasswordChar = '*';
            this.tBoxRegisterPassword.Size = new System.Drawing.Size(137, 22);
            this.tBoxRegisterPassword.TabIndex = 16;
            // 
            // tBoxRegisterEmail
            // 
            this.tBoxRegisterEmail.Location = new System.Drawing.Point(210, 59);
            this.tBoxRegisterEmail.Name = "tBoxRegisterEmail";
            this.tBoxRegisterEmail.Size = new System.Drawing.Size(137, 22);
            this.tBoxRegisterEmail.TabIndex = 15;
            // 
            // tBoxName
            // 
            this.tBoxName.Location = new System.Drawing.Point(210, 31);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(137, 22);
            this.tBoxName.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Wachtwoord:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "E-Mail:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(153, 34);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(49, 17);
            this.lbName.TabIndex = 11;
            this.lbName.Text = "Naam:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 356);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbCharBuilder);
            this.Name = "LoginForm";
            this.Text = "Log In";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btSendRegister;
        private System.Windows.Forms.TextBox tBoxConfirmEMail;
        private System.Windows.Forms.Label lbConfirmEMail;
        private System.Windows.Forms.TextBox tBoxConfirmPWord;
        private System.Windows.Forms.Label lbConfirmPWord;
        private System.Windows.Forms.TextBox tBoxRegisterPassword;
        private System.Windows.Forms.TextBox tBoxRegisterEmail;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbName;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KillerApp_WoD.Database;

namespace KillerApp_WoD
{
    public partial class LoginForm : Form
    {
        CharacterForm charForm = new CharacterForm();
        DatabaseClass database = new DatabaseClass();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btLogIn_Click(object sender, EventArgs e)
        { 
            //database.OpenConnection();
            if (database.LogIn(tBoxEMail.Text, tBoxPassword.Text))
            {
                charForm.Show();
            }
            else
            {
                MessageBox.Show("Er is een fout opgetreden: Uw wachtwoord of e-mailadres klopt niet.");
            }
            //database.CloseConnection();
            
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void btSendRegister_Click(object sender, EventArgs e)
        {
            if (tBoxRegisterEmail.Text == tBoxConfirmEMail.Text && tBoxRegisterPassword.Text == tBoxConfirmPWord.Text)
            {
                //database.OpenConnection();
                database.Register(tBoxName.Text, tBoxRegisterEmail.Text, tBoxRegisterPassword.Text);
                //database.CloseConnection();
                groupBox2.Visible = false;
            }
            else
            {
                MessageBox.Show("Er is een fout opgetreden, uw wachtwoord of e-mailadres komt niet overeen");
            }
        }
    }
}

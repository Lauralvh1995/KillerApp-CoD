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
        DatabaseClass database = new DatabaseClass();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btLogIn_Click(object sender, EventArgs e)
        {
            database.OpenConnection();
            database.LogIn(tBoxEMail.Text, tBoxPassword.Text);
            database.CloseConnection();
        }
    }
}

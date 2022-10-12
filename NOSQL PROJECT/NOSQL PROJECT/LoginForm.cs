using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOSQL_PROJECT
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Customize();
        }

        private void Customize()
        {
            btnLogin.Enabled = false;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            CheckText();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            CheckText();
        }

        private void CheckText()
        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                btnLogin.Enabled = true;
                btnLogin.BackColor = Color.FromArgb(22, 155, 213);
                btnLogin.ForeColor = Color.White;
            }
            else
            {
                btnLogin.Enabled = false;
                btnLogin.BackColor = Color.LightGray;
                btnLogin.ForeColor = Color.Black;
            }
        }
    }
}

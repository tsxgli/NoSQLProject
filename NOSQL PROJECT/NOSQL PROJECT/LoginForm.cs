using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODEL;
using LOGIC;

namespace NOSQL_PROJECT
{
    public partial class LoginForm : Form
    {
        private List<Employee> employees;
        private Employee currentUser;
        private EmployeeLogic employeeLogic;
        //private string currentUsername;
        public LoginForm()
        {
            employeeLogic = new EmployeeLogic();
            employees = employeeLogic.GetAllEmployees();
            currentUser = null;
            InitializeComponent();
            Customize();
        }

        private void Customize()
        {
            HidePanels();
            pnlLogin.Show();
            btnLogin.Enabled = false;
            btnConfirm.Enabled = false;
            //lblForgotPassword.Enabled = false;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            CheckLoginText();
            lblError.Text = "";
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            CheckLoginText();
            lblError.Text = "";
        }

        private void CheckLoginText()
        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                btnLogin.Enabled = true;
                btnLogin.BackColor = Color.FromArgb(22, 155, 213);
                btnLogin.ForeColor = Color.White;
            }
            else
            {

               // lblForgotPassword.Enabled = false;
                //if (txtUsername.Text != "")
                    //lblForgotPassword.Enabled = true;   
                btnLogin.Enabled = false;
                btnLogin.BackColor = Color.LightGray;
                btnLogin.ForeColor = Color.Black;
            }
        }

        private void CheckEmail()
        {
            if (txtEmail.Text != "")
            {
                btnConfirm.Enabled = true;
                btnConfirm.BackColor = Color.FromArgb(22, 155, 213);
                btnConfirm.ForeColor = Color.White;
            }
            else
            {
                btnConfirm.Enabled = false;
                btnConfirm.BackColor = Color.LightGray;
                btnConfirm.ForeColor = Color.Black;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool userExists = false;

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            foreach (Employee employee in employees)
            {
                if (employee.Username.Equals(username) && employee.Password.Equals(password))
                {
                    currentUser = employee;
                    userExists = true;
                }
            }

            if (userExists)
            {
                MainForm mainForm = new MainForm(currentUser);
                mainForm.Show();
                this.Hide();
            }
            else
                lblError.Text = "Invalid username/password combination.";
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            /*bool userExists = false;
            string currentUsername = txtUsername.Text.Trim();
            foreach(Employee employee in employees)
            {
                if(employee.Username.Equals(currentUsername))
                {
                    userExists = true;
                    this.currentUsername = currentUsername;
                }
            }*/
            HidePanels();
            pnlForgotPassword.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HidePanels();
            pnlLogin.Show();
        }

        private void HidePanels()
        {
            pnlForgotPassword.Hide();
            pnlLogin.Hide();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            CheckEmail();
            lblErrorForgetPassword.Text = "";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            bool emailExists = false;
            foreach(Employee employee in employees)
            {
                if (employee.Email.Equals(email))
                {
                    emailExists = true;
                }
            }

            if (emailExists)
            {
                lblErrorForgetPassword.Text = "nice";
            }
            else
                lblErrorForgetPassword.Text = "Invalid email.";

        }
    }
}

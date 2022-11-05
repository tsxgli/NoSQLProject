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
            btnLogin.Enabled = false;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            CheckText();
            lblError.Text = "";
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            CheckText();
            lblError.Text = "";
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
    }
}

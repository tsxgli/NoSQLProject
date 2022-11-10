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
using System.Net.Mail;
using System.Net;

namespace NOSQL_PROJECT
{
    public partial class LoginForm : Form
    {
        private List<Employee> employees;
        private Employee currentUser; //store the current user
        private EmployeeLogic employeeLogic; 
      
        public LoginForm()
        {
            //create connection to the service layer
            employeeLogic = new EmployeeLogic();

            //get all employees
            employees = employeeLogic.GetAllEmployees();
            currentUser = null;
            InitializeComponent();

            Customize();
        }

        private void Customize()
        {
            //hide the panels
            HidePanels();

            //show the login panel
            pnlLogin.Show();

            //disable the login and confirm buttons
            btnLogin.Enabled = false;
            btnConfirm.Enabled = false;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            //check for text change
            CheckLoginText();

            //clear error label
            lblError.Text = "";
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            //check for text change
            CheckLoginText();

            //clear error label
            lblError.Text = "";
        }

        private void CheckLoginText()
        {
            //if username and password fields are not empty enable login button
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                btnLogin.Enabled = true;
                btnLogin.BackColor = Color.FromArgb(22, 155, 213);
                btnLogin.ForeColor = Color.White;
            }
            else //else disable it
            {  
                btnLogin.Enabled = false;
                btnLogin.BackColor = Color.LightGray;
                btnLogin.ForeColor = Color.Black;
            }
        }

        private void CheckEmail()
        {
            //if email field is not empty enable confirm button
            if (txtEmail.Text != "")
            {
                btnConfirm.Enabled = true;
                btnConfirm.BackColor = Color.FromArgb(22, 155, 213);
                btnConfirm.ForeColor = Color.White;
            }
            else //else disable it
            {
                btnConfirm.Enabled = false;
                btnConfirm.BackColor = Color.LightGray;
                btnConfirm.ForeColor = Color.Black;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool userExists = false;

            //get the username and password from input
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            //go through all employees and check if one with the same username and password exists
            foreach (Employee employee in employees)
            {
                if (employee.Username.Equals(username) && employee.Password.Equals(password))
                {
                    //if it exists, store the current employee
                    currentUser = employee;
                    userExists = true;
                }
            }

            //if the user exists, open the main form and close login fornm
            if (userExists)
            {
                MainForm mainForm = new MainForm(currentUser);
                mainForm.Show();
                this.Hide();
            }
            else //else alert the user
                lblError.Text = "Invalid username/password combination.";
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            //hide panels
            HidePanels();

            //show forgot password panel
            pnlForgotPassword.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //hide panels
            HidePanels();

            //show the login panel
            pnlLogin.Show();
        }

        private void HidePanels()
        {
            //hide all panels
            pnlForgotPassword.Hide();
            pnlLogin.Hide();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            //check for text change
            CheckEmail();

            //clear error label
            lblErrorForgetPassword.Text = "";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //get the email from input
            string email = txtEmail.Text.Trim();

            Employee employeeChangePassword = new Employee();
            bool emailExists = false;

            //go through all employees to find one with the input email
            foreach(Employee employee in employees)
            {
                if (employee.Email.Equals(email))
                {
                    //if one is found, store it
                    emailExists = true;
                    employeeChangePassword = employee;
                }
            }

            //if the email belongs to an amployee, change his password and send it by email
            if (emailExists)
            {
                string password = PasswordGenerator.GenerateRandomPassword();
                employeeLogic.UpdateEmployeePassword(employeeChangePassword, password);
                SendEmail(email, password);
                lblErrorForgetPassword.Text = "Success";
            }
            else
                //else inform the user
                lblErrorForgetPassword.Text = "Invalid email.";

        }

        private void SendEmail(string email, string newPassword)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("nosqlproject2.1@gmail.com");
            mail.To.Add(email);
            mail.Subject = "NoDesk password change";
            mail.Body = $"Your new NoDesk password is {newPassword}";
            mail.IsBodyHtml = true;

            using SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("nosqlproject2.1@gmail.com", "kytvrwgerndngubn");
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }
    }
}

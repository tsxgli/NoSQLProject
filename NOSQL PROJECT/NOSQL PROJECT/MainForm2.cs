using DAL;
using LOGIC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MODEL;
using MongoDB.Bson;
using System.Net.Mail;
using System.Net;
using System.Linq;

namespace NOSQL_PROJECT
{
    public partial class MainForm2 : Form
    {
        //create connection to logic layer
        IncidentLogic incidentLogic;
        EmployeeLogic employeeLogic;
        List<Employee> employees;
         string password ;

        public MainForm2()
        {
            InitializeComponent();
            employeeLogic = new EmployeeLogic();
            incidentLogic = new IncidentLogic();
            employees = new List<Employee>();
            employees = employeeLogic.GetAllEmployees();
            PopulateComboBox();
            password = GenerateRandomPassword();
            pnlIncidentManagement.Visible = true;
            DisplayIncidents();
            pnlUserManagement.Visible = true;
            DisplayUsers();
        }

        public void AddIncidentToDB()
        {
            incidentLogic = new IncidentLogic();
            //create new ticket
            Ticket ticket = new Ticket();

            ticket.Subject = txtIncidentSubject.Text;
            switch (comb_IncidentPriority.GetItemText(comb_IncidentPriority.SelectedItem))
            {
                case "Low":
                    ticket.TicketPriority = TicketPriority.Low;
                    break;
                case "High":
                    ticket.TicketPriority = TicketPriority.High;
                    break;
                case "Normal":
                    ticket.TicketPriority = TicketPriority.Normal;
                    break;
                default:
                    ticket.TicketPriority = TicketPriority.Normal;
                    break;
            }
            ticket.Deadline = dtp_Deadline.Value;
            ticket.Description = txt_IncidentDescription.Text;
            ticket.ReportedDate = dtPick_IncidentTimeReported.Value;
            switch (comb_TypeIncident.GetItemText(comb_TypeIncident.SelectedItem))
            {
                case "Hardware":
                    ticket.TicketType = TicketType.Hardware;
                    break;
                case "Software":
                    ticket.TicketType = TicketType.Software;
                    break;
                case "Service":
                    ticket.TicketType = TicketType.Service;
                    break;
                default :
                    ticket.TicketType = TicketType.Service;
                    break;
            }

            ticket.UserReported = employees[comb_ReportedByUser.SelectedIndex];
            ticket.TicketStatus = TicketStatus.Open;

            //add ticket to database
            incidentLogic.AddNewIncident(ticket);
        }
        public void PopulateComboBox()
        {
            foreach (Employee e in employees)
            {
                comb_ReportedByUser.Items.Add($"{e.FirstName} {e.LastName}");
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddEmployeeToDatabase();
            MessageBox.Show("Employee has been added to database");
        }

        private void MainForm2_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmitTicket_Click(object sender, EventArgs e)
        {
            AddIncidentToDB();
            MessageBox.Show("Incident has been succesfully created.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // hide current panel and show the display users panel 
            panel1.Visible = false;
            pnlUserManagement.Visible = true;
            DisplayUsers();
        }        
        private void btn_CancelIncident_Click(object sender, EventArgs e)
        {
            // hide current panel and show the display incidents panel 
            pnlCreateTicket.Visible = false;
            pnlIncidentManagement.Visible = true;
            DisplayIncidents();
        }

        public void AddEmployeeToDatabase()
        {
            incidentLogic = new IncidentLogic();

            Employee employee= new Employee();

            employee.FirstName =txtFirstName.Text;
            employee.LastName =txtLastName.Text;
            employee.Email =txtEmail.Text;
            employee.Location = comboLocation.SelectedText;
            employee.PhoneNumber=txtPhoneNo.Text;
            employee.Password = password;
            employee.Username = txtUsername.Text;

            switch (comboUserType.GetItemText(comboUserType.SelectedItem))
            {
                case "Service Desk":
                    employee.UserType = UserType.ServiceDesk;
                    break;
                case "Regular":
                    employee.UserType = UserType.Regular;
                    break;
                default:
                    employee.UserType = UserType.Regular;
                    break;
            }

            if (checkBoxSendEmail.Checked)
            {
                SendEmail();
            }
            employeeLogic.AddNewEmployeeToDatabase(employee);
        }


        public string GenerateRandomPassword()
        {
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrs";
            char[] chars = new char[7];
            string finalPassword = "";
            Random random = new Random();

            for (int i = 0; i < 7; i++)
            {
                finalPassword += letters[random.Next(0, letters.Length)];
               // finalPassword += chars[i];
            }
            return finalPassword;
        }

        public void SendEmail()
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("nosqlproject2.1@gmail.com");
            mail.To.Add(txtEmail.Text);
            mail.Subject = "NoDesk password";
            mail.Body = $"Thank you for signing up for NoDesk. \nYour new password is {password}";
            mail.IsBodyHtml = true;

            using SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("nosqlproject2.1@gmail.com","kytvrwgerndngubn");
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlUserManagement.Visible = false;
            panel1.Visible = true;
        }

        private void btnCreateNewIncident_Click(object sender, EventArgs e)
        {
            pnlIncidentManagement.Visible = false;
            pnlCreateTicket.Visible = true;
        }
        private void DisplayUsers()
        {
            List<Employee>employees = employeeLogic.GetAllEmployees();

            foreach (Employee employee in employees)
            {
                ListViewItem item = new ListViewItem();
                item.Text = employee.Id.ToString();
                item.SubItems.Add(employee.Email);
                item.SubItems.Add(employee.FirstName);
                item.SubItems.Add(employee.LastName);
                item.SubItems.Add("test"); //method for count of tickets per user

                listViewOverviewUsers.Items.Add(item);
            }
        }
        private void DisplayIncidents()
        {
            List<Ticket> tickets = incidentLogic.GetIncidents();
            
            foreach(Ticket ticket in tickets)
            {
                ListViewItem item = new ListViewItem();
                item.Text = ticket.id.ToString();
                item.SubItems.Add(ticket.Subject);
                item.SubItems.Add(ticket.UserReported.Email);
                item.SubItems.Add(ticket.ReportedDate.ToString());
                item.SubItems.Add(ticket.TicketStatus.ToString());
                
                listViewIncidents.Items.Add(item);
            }
        }

    }
}

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Windows.Forms.VisualStyles;

namespace NOSQL_PROJECT
{
    public partial class MainForm2 : Form
    {
        //create connection to logic layer
        IncidentLogic incidentLogic;
        EmployeeLogic employeeLogic;

        Employee currentUser;
        List<Employee> employees;
        Employee selectedUser;
        Ticket currentTicket;
        string password ;

        public MainForm2(Employee currentUser)
        {
            this.currentUser = currentUser;
            //if(currentUser.UserType == UserType.Regular)
            //{
            //    tabControl1.TabPages[2].Visible = false;
            //}
            //this.currentEmployee = currentEmployee
            InitializeComponent();
            HideCRUDTools();
            employeeLogic = new EmployeeLogic();
            incidentLogic = new IncidentLogic();
            employees = new List<Employee>();
            employees = employeeLogic.GetAllEmployees();
            PopulateComboBox();
            password = GenerateRandomPassword();
            pnlIncidentManagement.Visible = true;
            DisplayIncidents(incidentLogic.GetIncidents());
            pnlUserManagement.Visible = true;
            DisplayUsers(employeeLogic.GetAllEmployees());
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
            // add 1 to the number of tickets reported of each user 
            ticket.UserReported.NoTicketsReported++;

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
            DisplayUsers(employeeLogic.GetAllEmployees());
        }        
        private void btn_CancelIncident_Click(object sender, EventArgs e)
        {
            // hide current panel and show the display incidents panel 
            pnlCreateTicket.Visible = false;
            pnlIncidentManagement.Visible = true;
            DisplayIncidents(incidentLogic.GetIncidents());
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
        private void DisplayUsers(List<Employee> employees)
        {
            listViewOverviewUsers.Items.Clear();
            foreach (Employee employee in employees)
            {
                ListViewItem item = new ListViewItem();
                item.Text = employee.Id.ToString();
                item.SubItems.Add(employee.Email);
                item.SubItems.Add(employee.FirstName);
                item.SubItems.Add(employee.LastName);
                item.SubItems.Add(employee.NoTicketsReported); 
                item.Tag = employee;

                listViewOverviewUsers.Items.Add(item);
            }
        }
        private void DisplayIncidents(List<Ticket>tickets)
        {
            pnlCreateTicket.Visible = false;
            pnlIncidentManagement.Visible = true;
            //if (currentUser.UserType == UserType.Regular)
            //{
            //    FilterIncidentsForUser();
            //}
            listViewIncidents.Items.Clear();
            foreach(Ticket ticket in tickets)
            {
                ListViewItem item = new ListViewItem();
                item.Text = ticket.id.ToString();
                item.SubItems.Add(ticket.Subject);
                item.SubItems.Add(ticket.UserReported.Email);
                item.SubItems.Add(ticket.ReportedDate.ToString());
                if (ticket.TicketStatus < TicketStatus.Escalated)
                {
                    item.SubItems.Add(ticket.TicketStatus.ToString());
                }   
                item.SubItems.Add(ticket.Description.ToString());
                item.Tag =ticket;
                
                listViewIncidents.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FilterIncidentsForUser();
        }
        private void FilterIncidentsForUser()
        {
            List<Ticket> tickets = incidentLogic.GetIncidents();
            List<Ticket> filteredTickets = new List<Ticket>();


            if (txtboxFilterEmailIncidents.Text.Length > 0)
            {
                foreach (Ticket ticket in tickets)
                {
                    if (ticket.UserReported.Email.Contains(txtboxFilterEmailIncidents.Text))
                    {
                        filteredTickets.Add(ticket);
                    }
                }
                txtboxFilterEmailIncidents.Clear();
                DisplayIncidents(filteredTickets);
            }
            else
            {
                DisplayIncidents(tickets);
            }
        }

        private void btnSearchUserByEmail_Click(object sender, EventArgs e)
        {
            List<Employee> users = employeeLogic.GetAllEmployees();
            List<Employee> filteredUsers = new List<Employee>();
            if (txtboxFilterEmailUsers.Text.Length > 0)
            {
                foreach (Employee employee in users)
                {
                    if (employee.Email.Contains(txtboxFilterEmailUsers.Text))
                    {
                        filteredUsers.Add(employee);
                    }
                }
                txtboxFilterEmailUsers.Clear();
                DisplayUsers(filteredUsers);
            }
            else
            {
                DisplayUsers(users);
            }
        }

        private void listViewOverviewUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewOverviewUsers.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem selectedItem = listViewOverviewUsers.SelectedItems[0];
            selectedUser = (Employee)selectedItem.Tag;

            tabControl1.SelectedTab = tabPage2;
            txtboxFilterEmailIncidents.Text = selectedUser.Email;
            button1_Click(sender, e);
            selectedUser = null;
        }

        private void listViewIncidents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewIncidents.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem selectedIncident = listViewIncidents.SelectedItems[0];
            DisplaySelectedIncident((Ticket)selectedIncident.Tag);
        }
        private void DisplaySelectedIncident(Ticket ticket)
        {
            pnlIncidentManagement.Visible = false;
            pnlCreateTicket.Visible = true;
            btnSubmitTicket.Hide();
            btn_CancelIncident.Location = new Point(0, 0);
            btnUpdateIncident.Show();
            btnDeleteIncident.Show();
            lblstatus.Show();
            comboboxStatus.Show();
            lblIncidentHeading.Text = "Incident Overview";

            ComboboxStatus();

            lblTicketIdStore.Text = ticket.id.ToString();
            txtIncidentSubject.Text = ticket.Subject;
            comb_TypeIncident.Text = ticket.TicketType.ToString();
            comb_ReportedByUser.Text = $"{ticket.UserReported.FirstName} {ticket.UserReported.LastName}";
            comb_IncidentPriority.Text = ticket.TicketPriority.ToString();
            dtPick_IncidentTimeReported.Text = ticket.ReportedDate.ToString();
            dtp_Deadline.Text = ticket.Deadline.ToString();
            txt_IncidentDescription.Text = ticket.Description;
            comboboxStatus.Text = ticket.TicketStatus.ToString();

        }
        private void ComboboxStatus()
        {
            comboboxStatus.Items.Clear();
            comboboxStatus.Items.Add(TicketStatus.Open);
            comboboxStatus.Items.Add(TicketStatus.Closed);
            comboboxStatus.Items.Add(TicketStatus.Resolved);
            comboboxStatus.Items.Add(TicketStatus.Escalated);
            if(comboboxStatus.Text == "Open") { comboboxStatus.BackColor = Color.Yellow; }
            else if(comboboxStatus.Text == "Resolved") { comboboxStatus.BackColor = Color.Green; }
            else if(comboboxStatus.Text == "Escalated") { comboboxStatus.BackColor = Color.Purple; }
            else { comboboxStatus.BackColor = Color.Orange; }
        }

        private void btnDeleteIncident_Click(object sender, EventArgs e)
        {
            ObjectId id = ObjectId.Parse(lblTicketIdStore.Text);
            lblTicketIdStore.Text = "";
            incidentLogic.DeleteIncident(id);
            HideCRUDTools();
            DisplayIncidents(incidentLogic.GetIncidents());
        }

        private void btnUpdateIncident_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket();

            ticket.id = ObjectId.Parse(lblTicketIdStore.Text);
            lblTicketIdStore.Text = "";
            ticket.ReportedDate = dtPick_IncidentTimeReported.Value;
            ticket.Subject = txtIncidentSubject.Text;
            ticket.Deadline = dtp_Deadline.Value;
            ticket.Description = txt_IncidentDescription.Text;
            ticket.ReportedDate = dtPick_IncidentTimeReported.Value;
            ticket.UserReported = employees[comb_ReportedByUser.SelectedIndex];
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
                default:
                    ticket.TicketType = TicketType.Service;
                    break;
            }
            switch (comboboxStatus.GetItemText(comboboxStatus.SelectedItem))
            {
                case "Open":
                    ticket.TicketStatus = TicketStatus.Open;
                    break;
                case "Closed":
                    ticket.TicketStatus = TicketStatus.Closed;
                    break;
                case "Resolved":
                    ticket.TicketStatus = TicketStatus.Resolved;
                    break;
                default:
                    ticket.TicketStatus = TicketStatus.Open;
                    break;
            }


            incidentLogic.UpdateIncident(ticket);
            HideCRUDTools();
            DisplayIncidents(incidentLogic.GetIncidents());

            MessageBox.Show("Incident has been updated!");
        }

        private void comboboxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboboxStatus.Text == "Open") { comboboxStatus.BackColor = Color.Yellow; }
            else if (comboboxStatus.Text == "Resolved") { comboboxStatus.BackColor = Color.Green; }
            else if (comboboxStatus.Text == "Escalated") { comboboxStatus.BackColor = Color.Purple; }
            else { comboboxStatus.BackColor = Color.Orange; }
        }
        private void HideCRUDTools()
        {
            btnSubmitTicket.Show();
            btn_CancelIncident.Location = new Point(776, 285);
            lblstatus.Hide();
            comboboxStatus.Hide();
            btnUpdateIncident.Hide();
            btnDeleteIncident.Hide();
        }
    }
}

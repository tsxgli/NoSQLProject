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
        SearchByKeywordLogic searchByKeywordLogic;

        Employee currentUser;
        List<Employee> employees;
        Employee selectedUser;

        //password that is going to be sent in an email
        string password;

        public MainForm2(Employee currentUser)
        {
            this.currentUser = currentUser;
            InitializeComponent();
            HideCRUDTools();
            employeeLogic = new EmployeeLogic();
            incidentLogic = new IncidentLogic();
            searchByKeywordLogic = new SearchByKeywordLogic();
            employees = new List<Employee>();
            // add all the employees to a list 
            employees = employeeLogic.GetAllEmployees();
            //add all the user names to the combo box
            PopulateComboBoxWithUserNames();
            // generate a random password for the new user 
            password = PasswordGenerator.GenerateRandomPassword();

            pnlIncidentManagement.Visible = true;
            if (currentUser.UserType != UserType.Regular)
                DisplayIncidents(incidentLogic.GetIncidents());
            else
            {
                DisplayIncidents(incidentLogic.GetIncidentByEmployeeEmail(currentUser.Email));
                HideControls();
            }

            pnlUserManagement.Visible = true;
            DisplayUsers(employeeLogic.GetAllEmployees());

            GenerateIncidentsPastDeadlineChart();
            GenerateUnresolvedIncidentsChart();
        }

        #region Create new incident 
        public void AddIncidentToDB()
        {
            incidentLogic = new IncidentLogic();
            //create new ticket
            Ticket ticket = new Ticket();
            ticket.Subject = txtIncidentSubject.Text;

            ticket.Deadline = dtp_Deadline.Value;
            ticket.Description = txt_IncidentDescription.Text;
            ticket.ReportedDate = dtPick_IncidentTimeReported.Value;
            ticket.UserReported = employees[comb_ReportedByUser.SelectedIndex];//employee who reports ticket is the user in the index of the list of employee
            ticket.TicketStatus = TicketStatus.Open;//create new tickets with open status
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
            // add 1 to the number of tickets reported of each user 
            ticket.UserReported.NoTicketsReported++;
            //update the number of tickets report by the employee reporter 
            employeeLogic.UpdateEmployee(ticket.UserReported);
            //add ticket to database
            incidentLogic.AddNewIncident(ticket);
        }
        private void btnSubmitTicket_Click(object sender, EventArgs e)
        {
            AddIncidentToDB();
            pnlUserManagement.Refresh();
            MessageBox.Show("Incident has been succesfully created.");
            ClearIncidentContentBoxes();
            pnlCreateTicket.Hide();
            pnlIncidentManagement.Show();
        }

        private void btn_CancelIncident_Click(object sender, EventArgs e)
        {
            // hide current panel and show the display incidents panel 
            pnlCreateTicket.Visible = false;
            pnlIncidentManagement.Visible = true;
            DisplayIncidents(incidentLogic.GetIncidents());
        }
        #endregion

        #region Add employee names to combobox
        public void PopulateComboBoxWithUserNames()
        {
            foreach (Employee e in employees)
            {
                comb_ReportedByUser.Items.Add($"{e.FirstName} {e.LastName}");
            }
        }
        #endregion

        #region Create employee
        public void AddEmployeeToDatabase()
        {
            incidentLogic = new IncidentLogic();

            Employee employee = new Employee();

            employee.FirstName = txtFirstName.Text;
            employee.LastName = txtLastName.Text;
            employee.Email = txtEmail.Text;
            employee.Location = comboLocation.SelectedText;
            employee.PhoneNumber = txtPhoneNo.Text;
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
                EmailSender.SendEmail(employee.Email, password);
            }
            employeeLogic.AddNewEmployeeToDatabase(employee);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddEmployeeToDatabase();
            MessageBox.Show("Employee has been added to database");
            ClearUserContentBoxes();
            pnlCreateUser.Hide();
            pnlUserManagement.Show();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // hide current panel and show the display users panel 
            pnlCreateUser.Visible = false;
            pnlUserManagement.Visible = true;
            DisplayUsers(employeeLogic.GetAllEmployees());
        }

        #endregion

        #region User Listview Controls

        private void btnCreateUserClick(object sender, EventArgs e)
        {
            pnlUserManagement.Visible = false;
            pnlCreateUser.Visible = true;
        }
        
        private void listViewOverviewUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when user is selected by service desk employee, the users tickets will be displayed in Incidentmanagement
            if (listViewOverviewUsers.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem selectedItem = listViewOverviewUsers.SelectedItems[0];
            selectedUser = (Employee)selectedItem.Tag;

            tabControl1.SelectedTab = tabIncidentManagement;
            txtboxFilterEmailIncidents.Text = selectedUser.Email;
            btnSearchTicketByEmail_Click(sender, e);
            selectedUser = null;
        }

        #endregion

        #region Incident Listview controls 
        private void btnCreateNewIncident_Click(object sender, EventArgs e)
        {
            pnlIncidentManagement.Visible = false;
            pnlCreateTicket.Visible = true;
        }

        private void listViewIncidents_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when a ticket is selected the details will be displayed available for CRUD actions
            if (listViewIncidents.SelectedItems.Count == 0)
            {
                return;
            }
            if (currentUser.UserType == UserType.ServiceDesk)
            {
                ListViewItem selectedIncident = listViewIncidents.SelectedItems[0];
                DisplaySelectedIncident((Ticket)selectedIncident.Tag);
            }
            else
            {
                return;
            }
        }
        private void DisplaySelectedIncident(Ticket ticket)
        {
            //Display one selected incident for CRUD actions
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
        #endregion

        #region Display Users
        private void DisplayUsers(List<Employee> employees)
        {
            //display the list of users for the service desk employees
            listViewOverviewUsers.Items.Clear();
            foreach (Employee employee in employees)
            {
                ListViewItem item = new ListViewItem();
                item.Text = employee.Id.ToString();
                item.SubItems.Add(employee.Email);
                item.SubItems.Add(employee.FirstName);
                item.SubItems.Add(employee.LastName);
                item.SubItems.Add(employee.NoTicketsReported.ToString());
                item.Tag = employee;

                listViewOverviewUsers.Items.Add(item);
            }
        }
        #endregion

        #region Display Incidents
        private void DisplayIncidents(List<Ticket> tickets)
        {
            //Display list of incidents with its details
            pnlCreateTicket.Visible = false;
            pnlIncidentManagement.Visible = true;
            if (currentUser.UserType == UserType.Regular)
            {
                tickets = incidentLogic.GetIncidentByEmployeeEmail(currentUser.Email);
            }
            listViewIncidents.Items.Clear();
            foreach (Ticket ticket in tickets)
            {
                ListViewItem item = new ListViewItem();
                item.Text = ticket.id.ToString();
                item.SubItems.Add(ticket.Subject);
                item.SubItems.Add(ticket.UserReported.Email);
                item.SubItems.Add(ticket.ReportedDate.Value.ToString("dd/MM/yyyy"));

                item.SubItems.Add(ticket.TicketStatus.ToString());

                item.SubItems.Add(ticket.Description.ToString());
                item.SubItems.Add(ticket.TicketPriority.ToString());
                item.Tag = ticket;

                // if ticket is not escalated, add it to listview
                if (ticket.TicketStatus < TicketStatus.Escalated)
                    listViewIncidents.Items.Add(item);
            }
        }
        #endregion

        #region Filter 
        private void btnSearchTicketByEmail_Click(object sender, EventArgs e)
        {
            //if keyletters are entered the incidents with the matching email will be shown
            FilterIncidentsForUser();
        }
        private void btnSearchTicketByKeyword_Click(object sender, EventArgs e)
        {
            //when keyletters are entered, the incidents with matching letters in the subject or description are shown
            listViewIncidents.Items.Clear();
            List<Ticket> ticketsToPrint = incidentLogic.GetIncidents();
            if (txtboxFilterByKeyword.Text.Length > 0)
            {
                ticketsToPrint = searchByKeywordLogic.GetIncidentWithKeywords(txtboxFilterByKeyword.Text);
            }
            txtboxFilterByKeyword.Clear();
            DisplayIncidents(ticketsToPrint);
        }

        private void FilterIncidentsForUser()
        {
            listViewIncidents.Items.Clear();
            List<Ticket> ticketsToPrint = incidentLogic.GetIncidents();


            if (txtboxFilterEmailIncidents.Text.Length > 0)
            {
                ticketsToPrint = incidentLogic.GetIncidentByEmployeeEmail(txtboxFilterEmailIncidents.Text);
            }
            txtboxFilterEmailIncidents.Clear();
            DisplayIncidents(ticketsToPrint);
        }

        private void btnSearchUserByEmail_Click(object sender, EventArgs e)
        {
            //when keyletters are entered the users with the matching emails are shown
            List<Employee> users = employeeLogic.GetAllEmployees();
            if (txtboxFilterEmailUsers.Text.Length > 0)
            {
                DisplayUsers(employeeLogic.GetEmployeeByEmail(txtboxFilterEmailUsers.Text));
            }
            else
            {
                DisplayUsers(users);
            }
        }

        #endregion

        #region Combobox Status 
        private void ComboboxStatus()
        {
            //to populate the combobox for displaying and changing the status
            comboboxStatus.Items.Clear();
            comboboxStatus.Items.Add(TicketStatus.Open);
            comboboxStatus.Items.Add(TicketStatus.Closed);
            comboboxStatus.Items.Add(TicketStatus.Resolved);
            comboboxStatus.Items.Add(TicketStatus.Escalated);
            if (comboboxStatus.Text == "Open") { comboboxStatus.BackColor = Color.Yellow; }
            else if (comboboxStatus.Text == "Resolved") { comboboxStatus.BackColor = Color.Green; }
            else if (comboboxStatus.Text == "Escalated") { comboboxStatus.BackColor = Color.Purple; }
            else { comboboxStatus.BackColor = Color.Orange; }
        }
        #endregion

        #region CRUD controls
        private void btnDeleteIncident_Click(object sender, EventArgs e)
        {
            //delete incident out of the database
            ObjectId id = ObjectId.Parse(lblTicketIdStore.Text);
            lblTicketIdStore.Text = "";
            incidentLogic.DeleteIncident(id);
            HideCRUDTools();
            ClearIncidentContentBoxes();
            DisplayIncidents(incidentLogic.GetIncidents());
        }

        private void btnUpdateIncident_Click(object sender, EventArgs e)
        {
            //update the information on an incident in the database
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
                case "Escalated":
                    ticket.TicketStatus = TicketStatus.Escalated;
                    break;
                default:
                    ticket.TicketStatus = TicketStatus.Open;
                    break;
            }

            incidentLogic.UpdateIncident(ticket);
            HideCRUDTools();
            ClearIncidentContentBoxes();
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
        #endregion

        #region Dashboard
        public void GenerateUnresolvedIncidentsChart()
        {
            var plt = new ScottPlot.Plot(350, 300);

            double[] values = { incidentLogic.GetIncidentsByStatus(TicketStatus.Open).Count, incidentLogic.GetIncidents().Count };
            string centerText = $"{values[0]}/{values[1]}";
            Color colorUnresolvedIncidents = Color.Orange;
            Color colorAllIncidents = Color.LightGray;

            var pie = plt.AddPie(values);
            pie.DonutSize = .6;
            pie.DonutLabel = centerText;
            pie.CenterFont.Color = Color.Gray;
            pie.SliceFillColors = new Color[] { colorUnresolvedIncidents, colorAllIncidents };

            plt.SaveFig("unresolvedIncidentsChart.png");
            unresolvedIncidentsPictureBox.Load("unresolvedIncidentsChart.png");
        }

        public void GenerateIncidentsPastDeadlineChart()
        {
            var plt = new ScottPlot.Plot(350, 300);

            double[] values = { incidentLogic.GetIncidentsByStatus(TicketStatus.PastDeadline).Count, incidentLogic.GetIncidents().Count };
            string centerText = values[0].ToString();
            Color colorIncidentsPastDeadline = Color.Red;
            Color colorAllIncidents = Color.LightGray;

            var pie = plt.AddPie(values);
            pie.DonutSize = .6;
            pie.DonutLabel = centerText;
            pie.CenterFont.Color = Color.Gray;
            pie.SliceFillColors = new Color[] { colorIncidentsPastDeadline, colorAllIncidents };

            plt.SaveFig("incidentsPastDeadlineChart.png");
            incidentsPastDeadlinePictureBox.Load("incidentsPastDeadlineChart.png");
        }

        private void showTicketsListBtn_Click_1(object sender, EventArgs e)
        {
            pnlDashboard.Hide();
            pnlIncidentManagement.Show();
            tabControl1.SelectedTab = tabIncidentManagement;
        }

        #endregion

        #region Clear Textboxes
        private void ClearIncidentContentBoxes()
        {
            dtPick_IncidentTimeReported.Value = DateTime.Today;
            dtp_Deadline.Value = DateTime.Today;
            txtIncidentSubject.Clear();
            comb_TypeIncident.SelectedIndex = -1;
            comb_IncidentPriority.SelectedIndex = -1;
            comb_ReportedByUser.SelectedIndex = -1;
            txt_IncidentDescription.Clear();
            comboboxStatus.SelectedIndex = -1;
            comb_TypeIncident.Text = "";
        }
        private void ClearUserContentBoxes()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhoneNo.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            comboUserType.Text = "";
            comboLocation.Text = "";
        }
        #endregion

        #region Sorting Button
        private void sortByPriorityBtn_Click(object sender, EventArgs e)
        {
            List<Ticket> sortedtickets = incidentLogic.SortTicketsByPriority();
            foreach (ListViewItem item in listViewIncidents.Items)
            {
                item.Remove();
            }
            DisplayIncidents(sortedtickets);
            listViewIncidents.Refresh();
        }
        #endregion

        #region Hide controls when user is regular employee
        private void HideControls()
        {
            txtboxFilterEmailIncidents.Hide();
            btnSearchTicketByEmail.Hide();
            btnSearchTicketByKeyword.Hide();
            txtboxFilterByKeyword.Hide();
            tabControl1.TabPages.Remove(tabUserManagement);
        }
        #endregion


        private void tabControl1_Click(object sender, EventArgs e)
        {
            pnlDashboard.Show();
        }
    }
}

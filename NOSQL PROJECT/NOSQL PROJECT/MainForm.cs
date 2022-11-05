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

namespace NOSQL_PROJECT
{
    public partial class MainForm : Form
    {
        //create connection to logic layer
        IncidentLogic incidentLogic;
        EmployeeLogic employeeLogic;
        List<Employee> employees;
        Employee currentUser;

        public MainForm(Employee currentUser)
        {
            InitializeComponent();
            employeeLogic = new EmployeeLogic();
            employees = new List<Employee>();
            employees = employeeLogic.GetAllEmployees();
            this.currentUser = currentUser;
            PopulateComboBox();
            
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
            //int index = comb_ReportedByUser.SelectedIndex;   
            ticket.UserReported = employees[comb_ReportedByUser.SelectedIndex];

            ticket.TicketStatus = TicketStatus.Open;

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

        }

        private void MainForm2_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmitTicket_Click(object sender, EventArgs e)
        {
            AddIncidentToDB();
            MessageBox.Show("Incident Created");
        }

    }
}

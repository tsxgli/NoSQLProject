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
    public partial class MainForm2 : Form
    {
        public MainForm2()
        {
            InitializeComponent();
            PopulateComboBox();
        }


        //create connection to logic layer
        IncidentLogic incidentLogic;
        EmployeeLogic employeeLogic;

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
            ticket.UserReported = (Employee)comb_ReportedByUser.SelectedValue;
            ticket.TicketStatus = TicketStatus.Open;

            incidentLogic.AddNewIncident(ticket);
        }
        public void PopulateComboBox()
        {
            employeeLogic = new EmployeeLogic();
            List<BsonDocument> employeeDocuments = new List<BsonDocument>();
            foreach (Employee e in employeeLogic.GetAllEmployees())
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

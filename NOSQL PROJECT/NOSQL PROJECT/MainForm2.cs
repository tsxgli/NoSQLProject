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
        }

        //create connection to logic layer
        IncidentLogic incidentLogic;
        EmployeeLogic employeeLogic = new EmployeeLogic();

        public void AddIncidentToDB()
        {
            incidentLogic = new IncidentLogic();
            //create new ticket
            Ticket ticket = new Ticket();

            ticket.Subject = txtIncidentSubject.Text;
            ticket.TicketPriority = (TicketPriority)comb_IncidentPriority.SelectedValue;
            ticket.Deadline = (DateTime)comb_IncidentDeadline.SelectedValue;
            ticket.Description = txt_IncidentDescription.Text;
            ticket.ReportedDate = dtPick_IncidentTimeReported.Value;
            ticket.UserReported = (Employee)comb_ReportedByUser.SelectedValue;
            ticket.TicketStatus = TicketStatus.Open;

            incidentLogic.AddNewIncident(ticket);
        }
        public void PopulateComboBox()
        {
            List<BsonDocument> employeeDocuments = new List<BsonDocument>();
            foreach (Employee e in employeeLogic.GetAllEmployees(employeeDocuments))
            {
                comb_ReportedByUser.Items.Add($"{e.FirstName} {e.LastName}");
            }
        }

    }
}

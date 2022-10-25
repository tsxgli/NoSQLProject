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

namespace NOSQL_PROJECT
{
    public partial class MainForm : Form
    {
        //create connection to logic layer
        IncidentDAO incidentDAO = new IncidentDAO();
        public MainForm()
        {
            InitializeComponent();
        }

        public void AddIncidentToDB()
        {
            //create new ticket
            Ticket ticket = new Ticket();

            ticket.Subject = txtIncidentSubject.Text;
            ticket.TicketPriority=(TicketPriority)comb_IncidentPriority.SelectedValue;
            ticket.Deadline = (DateTime)comb_IncidentDeadline.SelectedValue;
            

        }

        private void btnSubmitTicket_Click(object sender, EventArgs e)
        {

        }
    }
}

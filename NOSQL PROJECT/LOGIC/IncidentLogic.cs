using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using MODEL;

namespace LOGIC
{
    public class IncidentLogic
    {
        private IncidentDAO incidentDAO;
        public IncidentLogic()
        {
            incidentDAO = new IncidentDAO();
        }
        
        public void AddNewIncident(Ticket ticket)
        {
            incidentDAO.AddNewIncident(ticket);
        }

        public List<Ticket> GetAllIncidents()
        {
            return incidentDAO.GetAllIncidents();
        }

        public List<Ticket> GetIncidentsByStatus(TicketStatus status)
        {
            List<Ticket> allIncidents = GetAllIncidents();
            List<Ticket> incidentsByStatus = new List<Ticket>();

            foreach (var incident in allIncidents)
            {
                if (incident.TicketStatus == status || (int)incident.TicketStatus == (int)status)
                {
                    incidentsByStatus.Add(incident);
                }
            }
            return incidentsByStatus;
        }
    }
}

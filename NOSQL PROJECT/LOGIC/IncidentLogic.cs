using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using MODEL;
using MongoDB.Bson;

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
        public List<Ticket> GetIncidents()
        {
            return incidentDAO.GetAllIncidents();
        }
        public void DeleteIncident(ObjectId id)
        {
            incidentDAO.DeleteIncident(id);
        }

        public List<Ticket> GetIncidentsByStatus(TicketStatus status)
        {
            List<Ticket> incidents = GetIncidents();
            List<Ticket> incidentsByStatus = new List<Ticket>();

            foreach (var  incident in incidents)
            {
                if(incident.TicketStatus==status||(int)incident.TicketStatus==(int)status)
                {
                    incidentsByStatus.Add(incident);
                }
            }
            return incidentsByStatus;
        }

        public void UpdateIncident(Ticket ticket)
        {
            incidentDAO.UpdateIncident(ticket);
        }

        public List<Ticket> SortTicketsByPriority()
        {
            return incidentDAO.SortTicketsByPriority();
        }
    }
}

﻿using System;
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

        public List<Ticket> SortTicketsByPriority()
        {
            return incidentDAO.SortTicketsByPriority();
        }

        public void UpdateIncident(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public void DeleteIncident(ObjectId id)
        {
            throw new NotImplementedException();
        }
    }
}

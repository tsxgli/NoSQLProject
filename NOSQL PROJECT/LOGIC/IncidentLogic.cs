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
        public List<Ticket> GetIncidents()
        {
            return incidentDAO.GetAllIncidents();
        }
    }
}

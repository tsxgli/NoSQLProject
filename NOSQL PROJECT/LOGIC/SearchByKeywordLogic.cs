using DAL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Text;

namespace LOGIC
{
    public class SearchByKeywordLogic
    {
        IncidentDAO incidentDAO;

        public SearchByKeywordLogic()
        {
            incidentDAO = new IncidentDAO();
        }
        public List<Ticket> GetIncidentWithKeywords(string keyword)
        {
            return incidentDAO.GetIncidentWithKeywords(keyword);
        }
    }
}

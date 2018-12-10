using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SmartLead.Biz
{
    class LeadRepository
    {
        private List<Lead> leads;
        public Lead Retrieve(int LeadId)
        {
            Lead lead = new Lead();
            //code to retrieve
            //Temp hard values to retreive
            SmartLead.Biz.Lead Getlead = new SmartLead.Biz.Lead();
                
            if (LeadId == 1)
            { 
                lead.LeadID = Getlead.LeadID;
            lead.FirstName = "Fadi";
            lead.LastName = "Mamar";
            lead.SourceID = 1;
            lead.CampaignID = 1;
            lead.AgentID = 1;
            lead.Email = "fadimamar@hotmail.com";
            lead.EveningPhoneNo = "909-696-1620";
           
            }
            return lead;
        }
        public List<Lead> Retrive()
        {
            if (leads==null)
            {
                leads = new List<Lead>();
                leads.Add(new Lead() { LeadID = 1 });
                leads.Add(new Lead() { LeadID = 2 });
                }
            return leads;
        }
        public T RetrieveValue <T>(string sql, T defaultValue)
        {
            // call the database to return value. If no value is returned , return the default value.
            T value = defaultValue;
            return value;
        }
    }
}

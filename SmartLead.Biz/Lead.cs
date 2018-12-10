using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartLead.Common;
namespace SmartLead.Biz
{
    public class Lead
    {
        public int LeadID { get; set; }
        public int SourceID { get; set; }
        public int CampaignID { get; set; }
        public int StatusID { get; set; }
        public int AgentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public String Email { get; set; }
        public string DayPhoneNo { get; set; }
        public string EveningPhoneNo { get; set; }
        public String FullName
        {
            get { return FirstName + " " + LastName; }

        }

        public string SendWelcomeEmail(String message)
        {
            string subject = "Welcome " + FullName;
            var confirmation = EmailService.SendEmail(subject,"message",this.Email);
            return confirmation;
        }
        public static  List<string> SendWelcomeEmail(String message, List<Lead> leads)
        {
            var confirmations=new List<string> ();
            foreach (var lead in leads)
                {
               var  subject = "Important message for: " + lead.FullName;
                var confirmation = EmailService.SendEmail(subject, message, lead.Email);
                confirmations.Add(confirmation);
            }
            
          
            return confirmations;
        }
    }

}

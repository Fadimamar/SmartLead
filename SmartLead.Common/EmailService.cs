using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLead.Common
{
    public static class EmailService
    {
        /// <summary>
        /// Sends email message
        /// </summary>
        /// <param name="subject">Subject of the Email</param>
        /// <param name="message">Message text</param>
        /// <param name="recipent">Email address of message reipent</param>
        /// <returns></returns>
        public static string SendEmail(string subject, string message, string recipent)
        {
            // Code to send email

            var confirmation = "Message sent: " + subject;
            LoggingService.LogAction(confirmation);
            return confirmation;
        }
    }
}




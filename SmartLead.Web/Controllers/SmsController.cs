using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twilio.AspNet.Common;
using Twilio.AspNet.Mvc;
using Twilio.TwiML;

namespace SmartLead.Web.Controllers
{
    using Twilio.AspNet.Common;
    using Twilio.AspNet.Mvc;
    using Twilio.TwiML;


    public class SmsController : TwilioController
    {
        public TwiMLResult Index(SmsRequest incomingMessage)
        // to test with ngrok set sms message comein webhook address to public url established by ngrok
        //ngrok http 52444 -host-header="localhost:52444" 
        {
            var messagingResponse = new MessagingResponse();
            messagingResponse.Message("The copy cat says: " +
                                      incomingMessage.Body);

            return TwiML(messagingResponse);
        }
    }
}
   
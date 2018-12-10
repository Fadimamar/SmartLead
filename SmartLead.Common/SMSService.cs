using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.Rest.Api.V2010.Account;
using Twilio;
// Install the C# / .NET helper library from twilio.com/docs/csharp/install
namespace SmartLead.Common
{
    public static class  SMSService
    {
        public static string SendSMS(string message, string fromPhoneNumber, string toPhoneNumber)
        {

            if (fromPhoneNumber == null)
                throw new ArgumentNullException(nameof(fromPhoneNumber));
            if(toPhoneNumber==null)
                throw new ArgumentNullException(nameof(toPhoneNumber));
            if (message == null)
                throw new ArgumentNullException(nameof(message));
            // Code to send SMS
            const string accountSid = "AC1facc07110f36aaca9fa3aa27f5eb93f";
            const string authToken = "52f046aae4076bc8a59a4a3f248e52d0";

            TwilioClient.Init(accountSid, authToken);

            var Tmessage = MessageResource.Create(
               body: message,
               from: new Twilio.Types.PhoneNumber(fromPhoneNumber),
                to: new Twilio.Types.PhoneNumber(toPhoneNumber));

            //Console.WriteLine(message.Sid);
            var confirmation = "Message Sent: " +  fromPhoneNumber + " to " + toPhoneNumber + "-" + message;
            LoggingService.LogAction(Tmessage+"-"+confirmation);
            return confirmation;
        }
    }
}

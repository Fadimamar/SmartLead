using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SmartLead.Common.Tests
{
    [TestClass]
    public class SMSServiceTests
    {
        [TestMethod]
        public void SendSMSTest()
        {
            // Arrange
            string fromPhoneNumber = "+16263496912";
            string toPhoneNumber = "+17146148218";

            string messege = "Hello from Twilio";
            string expected = "Message Sent: " + fromPhoneNumber + " to " + toPhoneNumber + "-" + messege;

            // Act
            var confirmation = SMSService.SendSMS(messege, fromPhoneNumber, toPhoneNumber);
            // Assert
            Assert.AreEqual(expected, confirmation);
        }
    }
}
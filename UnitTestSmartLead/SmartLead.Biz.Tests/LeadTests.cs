using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartLead.Biz;


namespace SmartLead.Biz.Tests
{
[TestClass]
    public class LeadTests
    {
        [TestMethod]
        public void SendWelcomeEmailTest()
        {
            // Arrange
            var  lead = new Lead();
            lead.FirstName = "Fadi";
            lead.LastName = "Mamar";
            lead.Email = "fadimamar@hotmail.com";
            string messege = "Hello "+ lead.FullName ;
            string expected = "Message sent: Welcome" +
                " " + lead.FullName;

        // Act
        var confirmation = lead.SendWelcomeEmail(messege);
        // Assert
        Assert.AreEqual(expected, confirmation);
        }
    }
}

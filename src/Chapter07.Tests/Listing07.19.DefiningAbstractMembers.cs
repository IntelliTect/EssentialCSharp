using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_19.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Contact_GetSummaryOverridden()
        {
            Contact contact = new Contact("Inigo Montoya");
            contact.Address = "111 W St City, State 11111";

            string expected = "FirstName: Inigo" + Environment.NewLine +
                              "LastName: Montoya" + Environment.NewLine +
                              "Address: 111 W St City, State 11111" + Environment.NewLine;
            
            Assert.AreEqual(expected, contact.GetSummary());
        }

        [TestMethod]
        public void Appointment_GetSummaryOverridden()
        {
            Appointment appointment = new Appointment("Inigo Montoya");
            appointment.StartDateTime = DateTime.Now;
            appointment.EndDateTime = DateTime.Now.AddDays(1);
            appointment.Location = "111 W St City, State 11111";

            string expected = "Subject: Inigo Montoya" + Environment.NewLine +
                              $"Start: {appointment.StartDateTime}" + Environment.NewLine +
                              $"End: {appointment.EndDateTime}" + Environment.NewLine +
                              "Location: 111 W St City, State 11111";
            
            Assert.AreEqual(expected, appointment.GetSummary());
        }
    }
}

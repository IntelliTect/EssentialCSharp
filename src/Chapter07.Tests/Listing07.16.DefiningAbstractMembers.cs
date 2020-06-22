using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_16
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Contact_GetSummaryOverridden()
        {
            Contact contact = new Contact("Inigo Montoya")
            {
                Address = "111 W St City, State 11111"
            };

            string expected = "FirstName: Inigo" + Environment.NewLine +
                              "LastName: Montoya" + Environment.NewLine +
                              "Address: 111 W St City, State 11111" + Environment.NewLine;
            
            Assert.AreEqual(expected, contact.GetSummary());
        }

        [TestMethod]
        public void Appointment_GetSummaryOverridden()
        {
            Appointment appointment = new Appointment(
                   "Soccer tournament", "111 W St City, State 11111",
                   new DateTime(2008, 7, 19), new DateTime(2008, 7, 18));

            string expected = "Subject: Soccer tournament" + Environment.NewLine +
                              $"Start: {appointment.StartDateTime}" + Environment.NewLine +
                              $"End: {appointment.EndDateTime}" + Environment.NewLine +
                              "Location: 111 W St City, State 11111";
            
            Assert.AreEqual(expected, appointment.GetSummary());
        }
    }
}

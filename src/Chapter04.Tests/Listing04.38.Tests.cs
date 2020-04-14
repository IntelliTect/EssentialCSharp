using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_38.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ChangeTemperatureWithoutConditionalOperature()
        {
            bool eventFired = false;
            Thermostat thermostat = new Thermostat();
            thermostat.PropertyChanged += (object? sender, System.EventArgs e) =>
            {
                eventFired = true;
            };
            thermostat.Temperature = 42;
            Assert.IsTrue(eventFired);
        }

        public void ChangeHumidityWithConditionalOperature()
        {
            bool eventFired = false;
            Thermostat thermostat = new Thermostat();
            thermostat.PropertyChanged += (object? sender, System.EventArgs e) =>
            {
                eventFired = true;
            };
            thermostat.Humidity = 42;
            Assert.IsTrue(eventFired);
        }
    }
}
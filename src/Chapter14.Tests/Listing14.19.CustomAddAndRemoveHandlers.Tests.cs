using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_19.Tests
{
    using Listing14_19;
    using static AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_19.Thermostat;

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void AddRemoveHandlerWorks()
        {
            Thermostat t = new Thermostat();

            float temp = 0;

            Thermostat.EventHandler<TemperatureArgs> T_OnTemperatureChange = (sender, newTemperature) =>
            {
                temp = newTemperature.NewTemperature;
            };
            t.OnTemperatureChange += T_OnTemperatureChange;

            t.CurrentTemperature = 12;
            Assert.AreEqual(12, temp);

            t.OnTemperatureChange -= T_OnTemperatureChange;
            t.CurrentTemperature = 20;
            Assert.AreEqual(12, temp);

        }

    }
}
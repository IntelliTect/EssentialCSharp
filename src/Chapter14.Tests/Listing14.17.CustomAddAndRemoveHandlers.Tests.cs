
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_17.Tests;

using Listing14_17;
using static AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_17.Thermostat;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void AddRemoveHandlerWorks()
    {
        Thermostat t = new();

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

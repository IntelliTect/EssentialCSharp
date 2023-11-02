
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_39.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void ChangeTemperatureWithoutConditionalOperator()
    {
        bool eventFired = false;
        Thermostat thermostat = new();
        thermostat.PropertyChanged += (object? sender, EventArgs e) =>
        {
            eventFired = true;
        };
        thermostat.Temperature = 42;
        Assert.IsTrue(eventFired);
    }

    public static void ChangeHumidityWithConditionalOperator()
    {
        bool eventFired = false;
        Thermostat thermostat = new();
        thermostat.PropertyChanged += (object? sender, EventArgs e) =>
        {
            eventFired = true;
        };
        thermostat.Humidity = 42;
        Assert.IsTrue(eventFired);
    }
}

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_39.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void ChangeTemperatureWithoutConditionalOperator()
    {
        bool eventFired = false;
        Person person = new();
        person.PropertyChanged += (object? sender, EventArgs e) => eventFired = true;
        person.BirthYear = 1978;
        Assert.IsTrue(eventFired);
    }

    [TestMethod]
    public void ChangeHumidityWithConditionalOperator()
    {
        bool eventFired = false;
        Person person = new();
        person.PropertyChanged += (object? sender, EventArgs e) => eventFired = true;
        person.Age = 42;
        Assert.IsTrue(eventFired);
    }
}

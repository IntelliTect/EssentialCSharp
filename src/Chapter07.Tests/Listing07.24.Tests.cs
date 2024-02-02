namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_24.Tests;

[TestClass]
public class PeriodsOfTheDayTests
{
    [TestMethod]
    public void IsDeveloperWorkHours_ValidWorkingHours_ReturnsTrue()
    {
        Assert.IsTrue(PeriodsOfTheDay.IsDeveloperWorkHours(12));
    }

    [TestMethod]
    public void IsDeveloperWorkHours_ValidNonWorkingHours_ReturnsFalse()
    {
        Assert.IsFalse(PeriodsOfTheDay.IsDeveloperWorkHours(3));
    }

    [TestMethod]
    public void GetPeriodOfDay_Dawn_ReturnsDawn()
    {
        Assert.AreEqual("Dawn", PeriodsOfTheDay.GetPeriodOfDay(5));
    }

    [TestMethod]
    public void GetPeriodOfDay_Morning_ReturnsMorning()
    {
        Assert.AreEqual("Morning", PeriodsOfTheDay.GetPeriodOfDay(6));
    }

    [TestMethod]
    public void GetPeriodOfDay_Afternoon_ReturnsAfternoon()
    {
        Assert.AreEqual("Afternoon", PeriodsOfTheDay.GetPeriodOfDay(13));
    }

    [TestMethod]
    public void GetPeriodOfDay_Evening_ReturnsEvening()
    {
        Assert.AreEqual("Evening", PeriodsOfTheDay.GetPeriodOfDay(18));
    }

    [TestMethod]
    public void GetPeriodOfDay_InvalidHour_ReturnsInvalid()
    {
        int invalidHour = 25;

        var exceptionThrown = Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
        PeriodsOfTheDay.GetPeriodOfDay(invalidHour));
        Assert.IsTrue(exceptionThrown.Message.StartsWith($"The hour of the day specified ({invalidHour}) is invalid."));
    }
}

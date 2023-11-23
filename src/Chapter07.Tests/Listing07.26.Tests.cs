namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_26.Tests;

[TestClass]
public class ParenthesizedPatternsTests
{
    [TestMethod]
    public void IsOutsideOfStandardWorkHours()
    {
        TimeOnly time = new(8, 0, 0);
        Assert.IsTrue(new PeriodsOfTheDay().IsOutsideOfStandardWorkHours(time));
        time = new(9, 1, 0);
        Assert.IsFalse(new PeriodsOfTheDay().IsOutsideOfStandardWorkHours(time));
        time = new(12, 0, 0);
        Assert.IsTrue(new PeriodsOfTheDay().IsOutsideOfStandardWorkHours(time));
        time = new(13, 1, 0);
        Assert.IsFalse(new PeriodsOfTheDay().IsOutsideOfStandardWorkHours(time));
        time = new(16, 59, 0);
        Assert.IsFalse(new PeriodsOfTheDay().IsOutsideOfStandardWorkHours(time));
        time = new(17, 0, 0);
        Assert.IsTrue(new PeriodsOfTheDay().IsOutsideOfStandardWorkHours(time));
    }

    [TestMethod]
    public void TryGetPhoneButton()
    {
        Assert.IsTrue(PeriodsOfTheDay.TryGetPhoneButton('a', out char? button));
        Assert.AreEqual('2', button);
        Assert.IsTrue(PeriodsOfTheDay.TryGetPhoneButton('z', out button));
        Assert.AreEqual('9', button);
        Assert.IsTrue(PeriodsOfTheDay.TryGetPhoneButton('+', out button));
        Assert.AreEqual('0', button);
        Assert.IsFalse(PeriodsOfTheDay.TryGetPhoneButton('=', out button));
        Assert.IsNull(button);
    }
}

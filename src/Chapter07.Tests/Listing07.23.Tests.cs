namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_23.Tests;

[TestClass]
public class SolsticeHelperTests
{
    [TestMethod]
    public void IsSolstice_21DayWrongMonth_ReturnsFalse()
    {
        Assert.IsFalse(SolsticeHelper.IsSolstice(new DateTime(2019, 1, 21)));
    }

    [TestMethod]
    public void IsSolstice_21DayRightMonth_ReturnsTrue()
    {
        Assert.IsTrue(SolsticeHelper.IsSolstice(new DateTime(2023, 12, 21)));
    }

    [TestMethod]
    public void IsSolstice_20DayRightMonth_ReturnsTrue()
    {
        Assert.IsTrue(SolsticeHelper.IsSolstice(new DateTime(2024, 6, 21)));
    }

    [TestMethod]
    public void IsSolstice_WrongDayRightMonth_ReturnsFalse()
    {
        Assert.IsFalse(SolsticeHelper.IsSolstice(new DateTime(2024, 6, 15)));
    }

    [TestMethod]
    public void TryGetSolstice_21DayWrongMonth_ReturnsFalse()
    {
        Assert.IsFalse(SolsticeHelper.TryGetSolstice(new DateTime(2019, 1, 21), out string? solstice));
        Assert.IsNull(solstice);
    }

    [TestMethod]
    public void TryGetSolstice_21DayRightMonth_ReturnsTrueWinterSolstice()
    {
        Assert.IsTrue(SolsticeHelper.TryGetSolstice(new DateTime(2023, 12, 21), out string? solstice));
        Assert.AreEqual("Winter Solstice", solstice);
    }

    [TestMethod]
    public void TryGetSolstice_20DayRightMonth_ReturnsTrueSummerSolstice()
    {
        Assert.IsTrue(SolsticeHelper.TryGetSolstice(new DateTime(2024, 6, 21), out string? solstice));
        Assert.AreEqual("Summer Solstice", solstice);
    }

    [TestMethod]
    public void TryGetSolstice_WrongDayRightMonth_ReturnsFalse()
    {
        Assert.IsFalse(SolsticeHelper.TryGetSolstice(new DateTime(2024, 6, 15), out string? solstice));
        Assert.IsNull(solstice);
    }
}

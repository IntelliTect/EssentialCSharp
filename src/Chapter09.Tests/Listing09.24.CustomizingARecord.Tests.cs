namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_24.Tests;

[TestClass]
public class AngleTests
{
    [TestMethod]
    public void ToString_90Degrees_90DegreesFormatted()
    {
        string expected = $"90° 0' 0\"";
        string actual = new Angle(90, 0, 0).ToString();
        Assert.AreEqual<string>(
            expected,
            actual);
    }
    [TestMethod]
    public void ToString_90DegreesWithName_90DegreesFormatted()
    {
        string expected = $"RightAngle: 90° 0' 0\"";
        string actual = new Angle(90, 0, 0, "RightAngle").ToString();
        Assert.AreEqual<string>(
            expected,
            actual);
    }

    [TestMethod]
    public void Equals_CopyWithSameDegreesMinutesSecondsBut_AreEqual()
    {
        Angle angle1 = new(0,0,0, "90 degrees");
        Angle angle2 = new(0, 0, 0);
        Assert.AreEqual<Angle>(angle1, angle2);
    }
}

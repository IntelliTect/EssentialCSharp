using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_04.Tests;

[TestClass]
public class BookTests
{
    [TestMethod]
    public void Title_Null_ThrowsArgumentNullException() => _ = new Angle(0,0,0);
    
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
        Angle book1 = new(0,0,0, "90 degrees");
        Angle book2 = new(0, 0, 0);
        Assert.AreEqual<Angle>(book1, book2);
    }
}

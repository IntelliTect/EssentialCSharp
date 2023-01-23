using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_01.Tests;

[TestClass]
public class AngleTests
{
    [TestMethod]
    public void Create_AngleArray_ElementsAreUninitialized()
    {
        Angle angle = default;
        Angle[] angles = new Angle[1];
        Assert.AreEqual(angle, angles[0]);
    }

    [TestMethod]
    public void Equals_CopyWithSameDegreesMinutesSeconds_AreEqual()
    {
        Angle angle1 = new(0, 0, 0);
        Angle angle2 = new(0, 0, 0);
        Assert.AreEqual<Angle>(angle1, angle2);
    }
}

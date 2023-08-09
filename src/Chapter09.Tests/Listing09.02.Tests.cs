namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_02.Tests;

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
        Angle angle1 = new(1, 2, 3);
        Angle angle2 = new(1, 2, 3);
        Assert.AreEqual<Angle>(angle1, angle2);
    }

    [TestMethod]
    public void With_CopyWithSameDegreesMinutesSeconds_AreEqual()
    {
        Angle angle1 = new(1, 2, 3);
        Angle angle2 = angle1 with { };
        Assert.AreEqual<Angle>(angle1, angle2);
    }
}

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_06.Tests;
using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_02;
using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_06;

[TestClass]
public class CoordinateTests
{
    [TestMethod]
    public void With_Coordinate_AreEqual()
    {
        Coordinate coordinate1 = new(
            new Angle(180, 0, 0), new Angle(180, 0, 0));
        Coordinate coordinate2 = new(
            new Angle(180, 0, 0), new Angle(180, 0, 0));

        Assert.AreEqual<Coordinate>(coordinate1, coordinate2);
    }

    [TestMethod]
    public void Equality_WithNulls_Success()
    {
        Coordinate? coordinate1 = null;
        Coordinate? coordinate2 = null;

        Assert.IsTrue(coordinate1 == coordinate2);
    }

    [TestMethod]
    public void Equality_WithLeffNull_Success()
    {
        Coordinate? coordinate1 = null;
        Coordinate? coordinate2 = new(
            new Angle(180, 0, 0), new Angle(180, 0, 0));

        Assert.IsFalse(coordinate1 == coordinate2);
        Assert.IsFalse(coordinate2 == coordinate1);
    }
}

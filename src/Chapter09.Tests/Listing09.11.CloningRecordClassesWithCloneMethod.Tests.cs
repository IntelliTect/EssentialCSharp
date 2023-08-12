namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_11.Tests;

using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_11;


[TestClass]
public class CloneMethodTest
{
    [TestMethod]
    public void CloneMethod_TwoCoordinates_AreEqual()
    {
        Coordinate coord1 = new(new Listing09_02.Angle(120, 10, 10), new Listing09_02.Angle(230, 15, 15));
        Coordinate coord2 = coord1.Clone();

        Assert.AreEqual(coord1, coord2);
    }
}

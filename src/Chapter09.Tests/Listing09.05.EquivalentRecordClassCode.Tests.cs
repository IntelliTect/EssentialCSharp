namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_05.Tests;
using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_01;
using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_04;
using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Tests;

[TestClass]
public class CoordinateTests
{
    [TestMethod]
    public void With_Coordinate_IsReadOnly()
    {
        Coordinate coordinate1 = new(
            new Angle(180, 0, 0), new Angle(180, 0, 0));
        Coordinate coordinate2 = new(
            new Angle(180, 0, 0), new Angle(180, 0, 0));

        Assert.AreEqual<Coordinate>(coordinate1, coordinate2);
    }
}
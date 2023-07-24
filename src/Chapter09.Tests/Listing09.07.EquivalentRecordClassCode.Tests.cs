namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_07.Tests;

using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_02;
using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_05;
using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_07;


[TestClass]
public class CoordinateTests
{
    [TestMethod]
    public void EqualityContract_GetType()
    {
        Coordinate coordinate1 = new(
            new Angle(180, 0, 0), new Angle(180, 0, 0));
        NamedCoordinate geoCoordinate = new(
            new Angle(180, 0, 0), new Angle(180, 0, 0), "GeoCoordinate");

        Assert.AreEqual(coordinate1.ExternalEqualityContract, coordinate1.GetType());

        Assert.AreEqual(geoCoordinate.ExternalEqualityContract, geoCoordinate.GetType());
        Assert.AreEqual(((Coordinate)geoCoordinate).ExternalEqualityContract, ((Coordinate)geoCoordinate).GetType());
    }
}

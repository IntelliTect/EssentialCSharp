namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_03A.Tests;
using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_01;
using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Tests;

[TestClass]
public partial class CoordinateTests
{
    [TestMethod]
    public void Create_Coordinate_IsReadOnly()
    {
        Coordinate coordinate = new(
            new Angle(180, 0, 0), new Angle(180, 0, 0));
    }

    [TestMethod]
    public void With_Coordinate_IsReadOnly()
    {
        Coordinate coordinate1 = new(
            new Angle(180, 0, 0), new Angle(180, 0, 0));
        Coordinate coordinate2 = coordinate1 with {  };

        Assert.AreEqual<Coordinate>(coordinate1, coordinate2);
    }

    [TestMethod]
    public void EqualityContract_GetType()
    {
        Coordinate coordinate1 = new(
            new Angle(180, 0, 0), new Angle(180, 0, 0));
        GeoCoordinate coordinate2 = new(
            coordinate1.Longitude, coordinate1.Latitude, "Test");
        

        Assert.AreNotEqual<Type>(coordinate1.GetType(), coordinate2.GetType());
    }

    [TestMethod]
    public void GetHashCode_ChangeData_GetHashCodeChanges()
    {
        Coordinate coordinate = new(
            new Angle(180, 0, 0), new Angle(180, 0, 0));
        int hashCode1 = coordinate.GetHashCode();
    }
}

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_04.Tests;
using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_01;
using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_06B;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        NamedCoordinate coordinate2 = new(
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

    [TestMethod]
    public void With_Instance_Equivalent()
    {
        Coordinate coordinate1 = new(
            new Angle(180, 0, 0), new Angle(180, 0, 0));
        Coordinate coordinate2 = coordinate1 with { };
        Assert.AreEqual(coordinate1, coordinate2);
    }

    [TestMethod]
    public void With_DifferentInstance_NotEquivalent()
    {
        Coordinate coordinate1 = 
            new(new Angle(180, 0, 0), new Angle(180, 0, 0));
        Angle angle = new Angle(0, 0, 0);
        Coordinate coordinate2 = coordinate1 with
        {
            Latitude  = angle
        };
        Assert.AreNotEqual(coordinate1, coordinate2);
    }
}

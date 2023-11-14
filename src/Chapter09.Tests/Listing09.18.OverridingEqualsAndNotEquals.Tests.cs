namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_18.Tests;

using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_18;


[TestClass]
public class OverridingEquals
{
    [TestMethod]
    public void CheckIfEqual_Angles_and_Coordinates()
    {
        Angle angle1 = new(120, 20, 20, "FirstName");
        Angle angle2 = new(120, 20, 20, "SecondName");

        Angle angle3 = new(120, 20, 20, "FirstName");
        Angle angle4 = new(120, 20, 20, "SecondName");

        Coordinate coord1 = new(angle1, angle2);
        Coordinate coord2 = new(angle3, angle4);

        // Should be equal even though names are different
        Assert.IsTrue(angle1.Equals(angle3));
        Assert.IsTrue(angle2.Equals(angle4));

        Assert.IsTrue(coord1.Equals(coord2));

        // Checking ==
        Assert.IsTrue(angle1 == angle3);
        Assert.IsTrue(angle2 == angle4);

        Assert.IsTrue(coord1 == coord2);
    }

    [TestMethod]
    public void CheckIfNotEqual_Angles_and_Coordinates()
    {
        Angle angle1 = new(120, 20, 20, "FirstName");
        Angle angle2 = new(120, 20, 20, "SecondName");

        Angle angle3 = new(300, 15, 15, "FirstName");
        Angle angle4 = new(300, 15, 15, "SecondName");

        Coordinate coord1 = new(angle1, angle2);
        Coordinate coord2 = new(angle3, angle4);

        // Should not be equal even though names are the same
        Assert.IsFalse(angle1.Equals(angle3));
        Assert.IsFalse(angle2.Equals(angle4));

        Assert.IsFalse(coord1.Equals(coord2));

        // Checking !=
        Assert.IsTrue(angle1 != angle3);
        Assert.IsTrue(angle2 != angle4);

        Assert.IsTrue(coord1 != coord2);
    }
}

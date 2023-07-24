namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_18.Tests;

using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_18;


[TestClass]
public class OverridingEquals
{
    [TestMethod]
    public void Check_Equals_Not_Equals()
    {
        Angle angle1 = new Angle(120, 20, 20, "FirstName");
        Angle angle2 = new Angle(120, 20, 20, "SecondName");

        Angle angle3 = new Angle(120, 20, 20, "FirstName");
        Angle angle4 = new Angle(120, 20, 20, "SecondName");

        Coordinate coord1 = new Coordinate(angle1, angle2);
        Coordinate coord2 = new Coordinate(angle3, angle4);


        // Should be equal even though names are different
        Assert.IsTrue(angle1.Equals(angle3));
        Assert.IsTrue(angle2.Equals(angle4));
        Assert.IsTrue(coord1.Equals(coord2));

        // Checking ==
        Assert.IsTrue(angle1 == angle3);
        Assert.IsTrue(angle2 == angle4);

        Assert.IsTrue(coord1 == coord2);

        // Checking !=
        Assert.IsTrue(angle1 != angle2);
        Assert.IsTrue(angle3 != angle4);

        Assert.IsFalse(coord1 != coord2);
    }
}

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_09.Tests;

using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_09;


[TestClass]
public class ReadonlyStructTests
{
    [TestMethod]
    public void MoveMethod_Returns_New_Angle()
    {
        Angle angle1 = new(90, 10, 5);
        Angle angle2 = angle1.Move(130, 25, 10);

        // Assert we get the expected value returned from Move()
        Assert.AreEqual(new Angle(220, 35, 15), angle2);

        // Assert that Move() did not modify angle1
        Assert.AreEqual(new Angle(90, 10, 5), angle1);
    }
}

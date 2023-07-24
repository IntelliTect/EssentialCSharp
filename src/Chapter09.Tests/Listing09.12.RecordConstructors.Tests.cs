namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_12.Tests;

using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_12;


[TestClass]
public class RecordConstructorTest
{
    [TestMethod]
    public void Initializing_Records()
    {
        Angle angle1 = new Angle(120, 10, 10);
        Angle angle2 = new Angle("120", "10", "10");

        Assert.AreEqual(angle1, angle2);
    }
}

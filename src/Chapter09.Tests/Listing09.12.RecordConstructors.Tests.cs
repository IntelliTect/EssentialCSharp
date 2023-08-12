namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_12.Tests;

using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_12;


[TestClass]
public class RecordConstructorTest
{
    [TestMethod]
    public void Records_AdditionalConstructors_AllowDiffParameters()
    {
        Angle angle1 = new(120, 10, 10);
        Angle angle2 = new("120", "10", "10");

        Assert.AreEqual(angle1, angle2);
    }
}

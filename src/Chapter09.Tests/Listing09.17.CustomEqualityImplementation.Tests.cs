namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_17.Tests;

using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_17;


[TestClass]
public class CustomEqualityTest
{
    [TestMethod]
    public void Ignore_Name_Customization()
    {
        Angle angle1 = new(120, 20, 20, "FirstName");
        Angle angle2 = new(120, 20, 20, "SecondName");

        // Should be equal even though names are different
        Assert.IsTrue(angle1.Equals(angle2));
    }
}

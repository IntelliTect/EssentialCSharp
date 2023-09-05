namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_16.Tests;

using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_16;


[TestClass]
public class OverridingToStringTest
{
    [TestMethod]
    public void Override_ToString_MatchesExpectedValue()
    {
        Angle angle1 = new(120, 20, 20, "AngleName");
        Angle angle2 = new(320, 10, 10, null);

        string expected1 = $"AngleName: 120° 20' 20\"";
        string expected2 = $"320° 10' 10\"";

        string actual1 = angle1.ToString();
        string actual2 = angle2.ToString();

        // Different strings should be returned from ToString() depending on whether a name was provided
        Assert.AreEqual(actual1, expected1);
        Assert.AreEqual(actual2, expected2);
    }
}

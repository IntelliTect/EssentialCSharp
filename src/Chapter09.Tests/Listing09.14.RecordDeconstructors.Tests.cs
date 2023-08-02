namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_14.Tests;

using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_14;


[TestClass]
public class DeconstructorTest
{
    [TestMethod]
    public void DeconstructorValues_MatchAngleValues()
    {
        // The constructor is generated using positional parameters
        Angle angle = new(90, 10, 10);

        angle.Deconstruct(out int degrees, out int minutes, out int seconds);

        Assert.AreEqual(angle.Degrees, degrees);
        Assert.AreEqual(angle.Minutes, minutes);
        Assert.AreEqual(angle.Seconds, seconds);
    }
}

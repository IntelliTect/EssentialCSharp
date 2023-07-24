namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_14.Tests;

using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_14;


[TestClass]
public class DeconstructorTest
{
    [TestMethod]
    public void Calling_Deconstructor()
    {
        (int degrees, int minutes, int seconds) = (
            90, 0, 0);

        // The constructor is generated using positional parameters
        Angle angle = new(degrees, minutes, seconds);

        angle.Deconstruct(out int d, out int m, out int s);

        Assert.AreEqual(degrees, d);
        Assert.AreEqual(minutes, m);
        Assert.AreEqual(seconds, s);
    }
}

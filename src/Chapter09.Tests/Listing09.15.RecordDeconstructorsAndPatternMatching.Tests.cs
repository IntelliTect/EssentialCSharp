namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_15.Tests;

using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_04;


[TestClass]
public class PatternMatchingTest
{
    [TestMethod]
    public void Pattern_Matching()
    {
        (int degrees, int minutes, int seconds, string name) = (
            90, 0, 0, null);

        // The constructor is generated using positional parameters
        Angle angle = new(degrees, minutes, seconds, name);

        // Records have a deconstructor using the 
        // positional parameters.
        if (angle is (int, int, int, string) angleData)
        {
            // ..
            Assert.AreEqual(angle, angleData);
        }
    }
}

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_15.Tests;

using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_04;


[TestClass]
public class PatternMatchingTest
{
    [TestMethod]
    public void Deconstructor_CorrespondingParameters_EnablePatternMatching()
    {
        // The constructor is generated using positional parameters
        Angle angle = new(90, 0, 0, null);

        // Records have a deconstructor using the 
        // positional parameters.
        if (angle is (int, int, int, string) angleData)
        {
            // ..
            Assert.AreEqual(angle, angleData);
        }
    }
}

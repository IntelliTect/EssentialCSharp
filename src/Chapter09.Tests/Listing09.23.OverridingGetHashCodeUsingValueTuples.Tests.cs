namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_23.Tests;

[TestClass]
public class GetHashCodeCombineTest
{
    [TestMethod]
    public void GetHashCode_ValueTuple_SameHashCode()
    {
        Angle angle1 = new Angle(120, 20, 20, "name");
        var testTuple = (120, 20, 20);

        int hashcode1 = angle1.GetHashCode();
        int hashcode2 = testTuple.GetHashCode();

        Assert.AreEqual(hashcode1, hashcode2);
    }
}
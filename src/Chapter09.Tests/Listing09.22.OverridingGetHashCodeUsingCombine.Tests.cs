namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_22.Tests;

using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_22;

[TestClass]
public class GetHashCodeCombineTest
{
    [TestMethod]
    public void GetHashCode_EqualObjects_SameHashCode()
    {
        Angle angle1 = new Angle(120, 20, 20);

        int hashcode1 = angle1.GetHashCode();
        int hashcode2 = HashCode.Combine(120, 20, 20);

        Assert.IsTrue(hashcode1 == hashcode2);
    }

    [TestMethod]
    public void GetHashCode_DiffObjects_DiffHashCode()
    {
        Angle angle1 = new Angle(120, 20, 20);

        int hashcode1 = angle1.GetHashCode();
        int hashcode2 = HashCode.Combine(300, 15, 15);

        Assert.IsTrue(hashcode1 != hashcode2);
    }
}

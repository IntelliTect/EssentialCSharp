namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_20.Tests;

using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_20;


[TestClass]
public class ValueEqualityTest
{
    [TestMethod]
    public void ImplementValueEquality_CustomType_AreEqual()
    {
        Foo foo1 = new(10, "testName");
        Foo foo2 = new(10, "testName");

        Assert.IsTrue(foo1.Equals(foo2));
    }

    [TestMethod]
    public void ImplementValueEquality_CustomType_OtherIsNull()
    {
        Foo foo1 = new(10, "testName");

        Assert.IsFalse(foo1.Equals(null));
    }
}

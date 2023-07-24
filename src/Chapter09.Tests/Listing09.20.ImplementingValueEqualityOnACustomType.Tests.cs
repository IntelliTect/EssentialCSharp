namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_20.Tests;

using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_20;


[TestClass]
public class ValueEqualityTest
{
    [TestMethod]
    public void Implement_Value_Equality_Custom_Type()
    {
        Foo foo1 = new Foo(10, "testName");
        Foo foo2 = new Foo(10, "testName");

        Assert.IsTrue(foo1.Equals(foo2));
    }
}

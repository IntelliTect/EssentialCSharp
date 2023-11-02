
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_42.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void GetObject_CollectionWithItem_ReturnItem()
    {
        Assert.IsNotNull(NullabilityAttributesExamined.GetObject(
            new string[] { "item" }, item => item is not null));
    }

    [TestMethod]
    public void GetObject_GivenEmptyCollection_ReturnNull()
    {
        Assert.IsNull(NullabilityAttributesExamined.GetObject(
            System.Array.Empty<string>(), item => item is not null));
    }

    [TestMethod]
    public void GetObject_ViaMethod_ReturnNull()
    {
        Assert.IsNull(NullabilityAttributesExamined.Method());
    }
}

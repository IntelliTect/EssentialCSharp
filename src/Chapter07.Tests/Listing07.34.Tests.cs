using IntelliTect.TestTools.Console;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_34.Tests;

[TestClass]
public class DataConversionUsingTheAsOperatorTests
{
    [TestMethod]
    public void Load()
    {
        Contact contact = new("Inigo Montoya");
        PdaItem pdaItem = contact;
        Assert.AreEqual(contact, Contact.Load(pdaItem));
    }
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Load_InvalidType()
    {
        PdaItem pdaItem = new PdaItem();
        Contact.Load(pdaItem);
    }
    [TestMethod]
    public void LoadValidType_TestOutput()
    {
        Contact contact = new("Inigo Montoya");
        PdaItem pdaItem = contact;
        ConsoleAssert.Expect(
            "ObjectKey: 00000000-0000-0000-0000-000000000000",
            () => Contact.Load(pdaItem));
    }
}


namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_09.Tests;

[TestClass]
public class ContactTests
{
    [TestMethod]
    public void NameProperty_Overridden()
    {
        Contact contact = new();

        contact.Name = "Inigo Montoya";
        
        Assert.AreEqual("Inigo", contact.FirstName);
        Assert.AreEqual("Montoya", contact.LastName);
    }
}

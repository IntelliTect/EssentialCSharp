namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_59.Tests;

[TestClass]
public class PersonTests
{
    [TestMethod]
    public void Person_OnLastNameChanging_ArgumentNullExceptionThrown()
    {
        Person person = new()
        {
            LastName = "Montoya"
        };
        Assert.AreEqual("Montoya", person.LastName);
        Assert.ThrowsException<ArgumentNullException>(
               () => person.LastName = null!);
    }

    [TestMethod]
    public void Person_OnLastNameChanging_ArgumentExceptionThrown()
    {
        Person person = new()
        {
            LastName = "Montoya"
        };
        Assert.AreEqual("Montoya", person.LastName);
        Assert.ThrowsException<ArgumentException>(
               () => person.LastName = string.Empty);
    }

    [TestMethod]
    public void Person_OnFirstNameChanging_ArgumentNullExceptionThrown()
    {
        Person person = new()
        {
            FirstName = "Inigo"
        };
        Assert.AreEqual("Inigo", person.FirstName);
        Assert.ThrowsException<ArgumentNullException>(
               () => person.FirstName = null!);
    }

    [TestMethod]
    public void Person_OnFirstNameChanging_ArgumentExceptionThrown()
    {
        Person person = new()
        {
            FirstName = "Inigo"
        };
        Assert.AreEqual("Inigo", person.FirstName);
        Assert.ThrowsException<ArgumentException>(
               () => person.FirstName = string.Empty);
    }
}

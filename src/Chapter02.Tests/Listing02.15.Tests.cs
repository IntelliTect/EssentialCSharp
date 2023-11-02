
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_15.Tests;

[TestClass]
public class InterpolationTests
{
    [TestMethod]
    public void Main_CorrectOutput()
    {
        string firstName = "Inigo";
        string lastName = "Montoya";

        string expected = @$"Enter your first name: 
<<{firstName}
>>Enter your last name: 
<<{lastName}
>>Your full name is {firstName} {lastName}.";


        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
              Program.Main);


    }
}

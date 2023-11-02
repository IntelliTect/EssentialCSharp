
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_07.Tests;

[TestClass]
public class HeyYouTests
{
    [TestMethod]
    public void Main_Tests()
    {
        const string expected =
@"First Name: <<Inigo
>>Last Name: <<Montoya
>>Email Address: <<imontoya@IntelliTect.com
>>Inigo Montoya <imontoya@IntelliTect.com>";
        
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}

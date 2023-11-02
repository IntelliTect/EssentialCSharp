
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_19.Tests;

[TestClass]
public class RawLiteralsWithInterpolationTests
{
    [TestMethod]
    public void Main_CorrectOutput()
    {
        const string firstName = "Inigo";
        const string lastName = "Montoya";

        const string expected = $@"Enter your first name: 
<<{firstName}
>>Enter your last name: 
<<{lastName}
>>Hello, I'm {firstName}. {firstName} {lastName}";

        string result = IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
             Program.Main);

    }
}

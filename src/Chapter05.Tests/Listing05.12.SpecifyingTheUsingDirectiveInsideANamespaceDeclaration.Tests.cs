
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_12.Tests;

[TestClass]
public class ProgramTests
{

    [TestMethod]
    public void Main_UsingToAvoidFullyQualifying_MethodCalledAsExpected()
    {
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            Listing05_08.Tests.ProgramTests.Expected, Program.Main);
    }
}

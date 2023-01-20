using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_11.Tests;

[TestClass]
public class ProgramTests
{

    [TestMethod]
    public void Main_UsingToAvoidFullyQualifying_MethodCalledAsExpected()
    {
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            Listing05_10.Tests.ProgramTests.Expected, Program.Main);
    }
}

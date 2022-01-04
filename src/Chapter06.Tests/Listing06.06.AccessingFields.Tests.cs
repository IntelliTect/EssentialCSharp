using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_06.Tests
{
[TestClass]
public class ProgramTests
{
    [System.Diagnostics.CodeAnalysis.NotNull]
    public TestContext? TestContext { get; set; }

    [TestMethod]
    public void Main_AccessingFields_WriteFieldValues()
    {
        Assert.IsNotNull(TestContext);
            const string expected =
                @"Inigo Montoya: Enough to survive on";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}

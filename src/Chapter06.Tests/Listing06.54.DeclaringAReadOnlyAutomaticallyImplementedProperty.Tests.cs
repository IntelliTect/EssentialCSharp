using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_54.Tests;

[TestClass]
public class DirectoryTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"System.Boolean[,,]";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}

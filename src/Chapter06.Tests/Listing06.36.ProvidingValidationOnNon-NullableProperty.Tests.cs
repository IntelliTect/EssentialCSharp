namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_36.Tests;

[TestClass]
public class EmployeeTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"Inigo Montoya";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}

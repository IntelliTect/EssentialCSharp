
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_18.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"Corporate
Human Resources
Engineering
Information Technology
Philanthropy
Marketing

Mark Michaelis (Chief Computer Nerd)
Michael Stokesbary (Senior Computer Wizard)
Brian Jones (Enterprise Integration Guru)
Anne Beard (HR Director)
Pat Dever (Enterprise Architect)
Kevin Bost (Programmer Extraordinaire)
Thomas Heavey (Software Architect)
Eric Edmonds (Philanthropy Coordinator)";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
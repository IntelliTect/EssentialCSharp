
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_21.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"
Mark Michaelis (Chief Computer Nerd)
	Count: 1

Michael Stokesbary (Senior Computer Wizard)
Brian Jones (Enterprise Integration Guru)
Kevin Bost (Programmer Extraordinaire)
Thomas Heavey (Software Architect)
	Count: 4

Anne Beard (HR Director)
	Count: 1

Pat Dever (Enterprise Architect)
	Count: 1

Eric Edmonds (Philanthropy Coordinator)
	Count: 1";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
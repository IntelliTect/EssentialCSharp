using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_19.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void EnumerableJoinTest()
        {
            string expected =
@"Mark Michaelis (Chief Computer Nerd)
	Corporate
Michael Stokesbary (Senior Computer Wizard)
	Engineering
Brian Jones (Enterprise Integration Guru)
	Engineering
Anne Beard (HR Director)
	Human Resources
Pat Dever (Enterprise Architect)
	Information Technology
Kevin Bost (Programmer Extraordinaire)
	Engineering
Thomas Heavey (Software Architect)
	Engineering
Eric Edmonds (Philanthropy Coordinator)
	Philanthropy";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            () =>
            {
                Program.Main();
            });
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_22.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void EnumerableGroupJoinTest()
        {
            string expected =
@"Corporate
	Mark Michaelis (Chief Computer Nerd)
Human Resources
	Anne Beard (HR Director)
Engineering
	Michael Stokesbary (Senior Computer Wizard)
	Brian Jones (Enterprise Integration Guru)
	Kevin Bost (Programmer Extraordinaire)
	Thomas Heavey (Software Architect)
Information Technology
	Pat Dever (Enterprise Architect)
Philanthropy
	Eric Edmonds (Philanthropy Coordinator)
Marketing";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            () =>
            {
                Program.Main();
            });
        }
    }
}

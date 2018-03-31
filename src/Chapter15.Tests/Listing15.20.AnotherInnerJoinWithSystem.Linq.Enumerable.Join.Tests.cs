using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_20.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void EnumerableJoinTest()
        {
            string expected =
@"Corporate
	Mark Michaelis (Chief Computer Nerd)
Human Resources
	Anne Beard (HR Director)
Engineering
	Michael Stokesbary (Senior Computer Wizard)
Engineering
	Brian Jones (Enterprise Integration Guru)
Engineering
	Kevin Bost (Programmer Extraordinaire)
Engineering
	Thomas Heavey (Software Architect)
Information Technology
	Pat Dever (Enterprise Architect)
Philanthropy
	Eric Edmonds (Philanthropy Coordinator)";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            () =>
            {
                Program.Main();
            });
        }
    }
}

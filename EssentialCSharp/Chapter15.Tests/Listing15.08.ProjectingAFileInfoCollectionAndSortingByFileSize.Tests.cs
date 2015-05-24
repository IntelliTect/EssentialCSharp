using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_08.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ProjectionWithLinqsSelect()
        {
            string expected =
$@".\IntelliTect.Console.dll(*)
.\Chapter15.Tests.dll(*)
.\IntelliTect.Console.pdb(*)
.\Chapter15.Tests.pdb(*)
.\Chapter15.exe(*)
.\Chapter15.pdb(*)";

            IntelliTect.ConsoleView.Tester.AreLike(expected,
            () =>
            {
                Program.Main();
            });
        }
    }
}
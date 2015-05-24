using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_15.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Listing14_15_Test()
        {
            string expected =
$@"{ Directory.GetCurrentDirectory() }\Chapter14.exe
{ Directory.GetCurrentDirectory() }\Chapter14.pdb
{ Directory.GetCurrentDirectory() }\Chapter15.exe
{ Directory.GetCurrentDirectory() }\Chapter15.pdb
{ Directory.GetCurrentDirectory() }\Chapter15.Tests.dll
{ Directory.GetCurrentDirectory() }\Chapter15.Tests.pdb
{ Directory.GetCurrentDirectory() }\IntelliTect.Console.dll
{ Directory.GetCurrentDirectory() }\IntelliTect.Console.pdb";

            IntelliTect.ConsoleView.Tester.AreLike(expected,
            () =>
            {
                Program.Main();
            });
        }
    }
}
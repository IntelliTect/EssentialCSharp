using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_07.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ProjectionWithLinqsSelect()
        {
            string expected =
$@"{
  Directory.GetCurrentDirectory() }\Chapter15.pdb
{ Directory.GetCurrentDirectory() }\Chapter15.exe
{ Directory.GetCurrentDirectory() }\Chapter15.Tests.pdb
{ Directory.GetCurrentDirectory() }\IntelliTect.Console.pdb
{ Directory.GetCurrentDirectory() }\Chapter15.Tests.dll
{ Directory.GetCurrentDirectory() }\IntelliTect.Console.dll";

            IntelliTect.ConsoleView.Tester.Test(expected,
            () =>
            {
                Program.Main();
            });
        }
    }
}
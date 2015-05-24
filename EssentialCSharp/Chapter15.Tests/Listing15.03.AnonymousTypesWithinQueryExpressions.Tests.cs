using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_03.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ProjectionWithLinqsSelect()
        {
            string expected =
$@"{
  Directory.GetCurrentDirectory() }\Chapter15.exe(*)
{ Directory.GetCurrentDirectory() }\Chapter15.pdb(*)
{ Directory.GetCurrentDirectory() }\Chapter15.Tests.dll(*)
{ Directory.GetCurrentDirectory() }\Chapter15.Tests.pdb(*)
{ Directory.GetCurrentDirectory() }\IntelliTect.Console.dll(*)
{ Directory.GetCurrentDirectory() }\IntelliTect.Console.pdb(*)";

            IntelliTect.ConsoleView.Tester.AreLike(expected,
            () =>
            {
                Program.Main();
            });
        }
    }
}
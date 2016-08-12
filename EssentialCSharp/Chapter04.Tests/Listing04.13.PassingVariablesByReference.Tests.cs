using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_12.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_WriteSwappedVariables()
        {
            string view = @"first = ""goodbye"", second = ""hello""";

            Intellitect.ConsoleView.Tester.Test(view,
            () =>
            {
                Program.ChapterMain();
            });
        }
    }
}
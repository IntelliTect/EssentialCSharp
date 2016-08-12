using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_03.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_InputInigo_WriteHelloInigo()
        {
            const string expected =
            @"Enter your first name: <<Inigo
>>Hello Inigo!";

            Intellitect.ConsoleView.Tester.Test(
                expected, Program.ChapterMain);
        }
    }
}
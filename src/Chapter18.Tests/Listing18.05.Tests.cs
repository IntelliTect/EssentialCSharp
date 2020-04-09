using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_05.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_WithNoParameters_DisplaysHelp()
        {
            string expected = @"True
True
False
True";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            () =>
            {
                Program.Main();
            });
        }
    }
}
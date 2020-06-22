using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_38
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void MainTest()
        {
            const string expected = @"Inigo Montoya: Too Little
Inigo Montoya: Too Little
Inigo Montoya: Too Little";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, () =>
                {
                    Program.Main();
                });
        }
    }
}

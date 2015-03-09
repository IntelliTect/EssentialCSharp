using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_07.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_WriteBooleanStatements()
        {
            const string expected =
@"True: result != number
True: result == number";

            IntelliTect.ConsoleView.Tester.Test(
                expected, Program.Main);
        }
    }
}
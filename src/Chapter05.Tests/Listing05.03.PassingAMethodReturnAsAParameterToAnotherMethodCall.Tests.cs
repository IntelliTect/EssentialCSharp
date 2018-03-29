using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_03.Tests
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

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}

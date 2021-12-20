using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_03.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ObservingUnhandledExceptionsWithContinueWith()
        {
            string expected = @"Before
Starting...
Continuing A...
Continuing C...
Continuing B...
Finished!";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            () =>
            {
                Program.Main();
            });
        }
    }
}
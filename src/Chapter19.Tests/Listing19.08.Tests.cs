
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_08.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ObservingUnhandledExceptionsWithContinueWith()
        {
            string expected = "ERROR: Operation is not valid due to the current state of the object.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            () =>
            {
                Program.Main();
            });
        }
    }
}
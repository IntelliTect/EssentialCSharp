using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_07a.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void SortedDictionaryOutputOrder()
        {
            string expected = string.Join(
                System.Environment.NewLine,
                "Error","Information", "Verbose", "Warning");

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            () =>
            {
                Program.Main();
            });
        }
    }
}
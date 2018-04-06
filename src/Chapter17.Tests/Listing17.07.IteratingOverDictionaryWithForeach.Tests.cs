using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_07.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void DictionaryInitialization()
        {
            string expected = string.Join(
                System.Environment.NewLine,
                "Error","Warning", "Information", "Verbose");

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            () =>
            {
                Program.Main();
            });
        }
    }
}
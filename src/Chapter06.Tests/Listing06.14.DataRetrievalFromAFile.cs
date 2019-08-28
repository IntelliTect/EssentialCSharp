using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_14.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_WriteToFileThenRetrieveDataFromFile_WriteStoredDataToScreen()
        {
            const string expected =
@"Name changed to 'Inigo Montoya'
Inigo Montoya: ";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}

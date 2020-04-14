using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_25.Tests
{
    [TestClass]
    public class ProgramTests
    {

        [TestMethod]
        public void Main_EncryptFile_Success()
        {
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                "Inigo Montoya", () => Program.Main());
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_22
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

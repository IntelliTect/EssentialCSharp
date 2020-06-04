using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_23
{
    [TestClass]
    public class ProgramTests
    {

        [TestMethod]
        public void Main_EncryptFile_Success()
        {
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                "(5, Princess)", () => Program.Main());
        }
    }
}

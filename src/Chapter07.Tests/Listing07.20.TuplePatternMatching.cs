using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Threading.Tasks;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_20
{
    [TestClass]
    public class ProgramTests
    {

        [TestMethod]
        public async Task Main_EncryptFile_Success()
        {

            const string encryptedFileName = "temp.out";
            const string data = "DATA";
            await File.WriteAllTextAsync(Program.DataFile, data);
            string expected = $"ENCRYPTED <{data}> ENCRYPTED";

            Program.Main("Encrypt", encryptedFileName);

            string actual = await File.ReadAllTextAsync(encryptedFileName);
            Assert.AreEqual<string>(expected, actual);
        }

        [TestMethod]
        public async Task Main_ShowFile_Success()
        {
            const string data = "DATA";
            await File.WriteAllTextAsync(Program.DataFile, data);

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                data,
                ()=>Program.Main("show"));
        }
    }
}

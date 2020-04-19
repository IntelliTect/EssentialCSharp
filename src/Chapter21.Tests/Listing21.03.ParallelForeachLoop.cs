using System.IO;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter21.Listing21_03
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ProgramTests
    {
#pragma warning disable CS8618 // Value is set by MSTest
        public TestContext TestContext { get; set; }
#pragma warning restore CS8618 

        [TestMethod]
        public void EncryptDecrypt_GivenSmallFile_EncryptDecryptSuccessfully()
        {
            string fileName = Path.GetTempFileName();
            string text = "You've fallen for one of the two classic blunders! The first being never get involved in a land war in Asia but only slightly lesser known: never go in against a cicelean when DEATH is on the line! HAHAHAHAHAHAHA *dies* You only think I guessed wrong! That's what's so funny! I switched glasses when your back was turned! Ha ha! You fool! You fell victim to one of the classic blunders - The most famous of which is 'never get involved in a land war in Asia' - but only slightly less well - known is this: 'Never go against a Sicilian when death is on the line!' Ha ha ha ha ha ha ha!";
            TestContext.WriteLine(text.Length.ToString());
            AssertEncryptIsDecryptedSuccessfully(fileName, text);
        }

        private static void AssertEncryptIsDecryptedSuccessfully(string fileName, string text)
        {
            File.WriteAllText(fileName, text);
            string encryptedFileName = Program.Encrypt(fileName);
            Assert.IsTrue(File.Exists(encryptedFileName));
            Program.Decrypt(encryptedFileName, fileName);
            string decryptedText = File.ReadAllText(fileName);
            Assert.AreEqual<string>(text, decryptedText);
        }
    }
}

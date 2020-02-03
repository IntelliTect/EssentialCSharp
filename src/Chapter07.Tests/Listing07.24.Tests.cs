using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Threading.Tasks;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_24.Tests
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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_15
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_ExpectHiddentAndReadOnlyFlags()
        {
            Directory.SetCurrentDirectory(AppContext.BaseDirectory);
            FileAttributes fileAttributes;
            string expected;

            if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                // The only working file attribute on Linux is ReadOnly.
                fileAttributes = FileAttributes.ReadOnly;
                Assert.AreEqual<int>(1, (int)fileAttributes);
                expected = $@"ReadOnly = {(int)fileAttributes}";
            }
            else
            {
                fileAttributes = FileAttributes.Hidden | FileAttributes.ReadOnly;
                Assert.AreEqual<int>(3, (int)fileAttributes);
                expected = $@"ReadOnly, Hidden = {(int)fileAttributes}";
            }
            
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}

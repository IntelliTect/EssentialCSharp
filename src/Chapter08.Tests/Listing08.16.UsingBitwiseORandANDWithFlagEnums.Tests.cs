using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_16.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_ExpectHiddentAndReadOnlyFlags()
        {
            Directory.SetCurrentDirectory(AppContext.BaseDirectory);
            FileAttributes fileAttributes = FileAttributes.Hidden | FileAttributes.ReadOnly;

            if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                // The only working file attribute on Linux is ReadOnly.
                fileAttributes = FileAttributes.ReadOnly;
            }
            string expected =
                $@"Hidden | ReadOnly = {fileAttributes}";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}
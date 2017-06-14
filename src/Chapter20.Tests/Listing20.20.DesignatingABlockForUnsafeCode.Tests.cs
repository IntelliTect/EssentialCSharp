using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_20.Tests
{
    [TestClass]
    public class Listing20_20_Tests
    {

        [TestMethod]
        public void GetProcessorIdReturnsCorrectValue()
        {
            string expected = @"Processor Id: GenuineIntel";
            if (!System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                expected = "This sample is only valid for Windows";
            }

                IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            () =>
            {
                Program.ChapterMain();
            });
        }
    }
}

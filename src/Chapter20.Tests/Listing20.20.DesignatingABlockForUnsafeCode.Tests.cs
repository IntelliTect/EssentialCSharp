using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_20.Tests
{
    [TestClass]
    public class Listing20_20_Tests
    {

        [TestMethod]
        public void GetProcessorIdReturnsCorrectValue()
        {
            string expected = @"Processor Id: GenuineIntel
Press any key to continue";

            
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            () =>
            {
                Program.ChapterMain();
            });
        }
    }
}

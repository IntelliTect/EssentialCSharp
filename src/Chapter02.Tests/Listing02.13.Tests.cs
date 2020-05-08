﻿using System;
using IntelliTect.TestTools.Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_13.Tests
{
    [TestClass]
    public class DuelOfWitsTests
    {
        [TestMethod]
        public void Main_WriteDizzyQuote()
        {
            const string expected = "\"Truly, you have a dizzying intellect.\"\n\"Wait 'til I get going!\"\n";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, (Action)DuelOfWits.Main, NormalizeOptions.StripAnsiEscapeCodes);
        }
    }
}
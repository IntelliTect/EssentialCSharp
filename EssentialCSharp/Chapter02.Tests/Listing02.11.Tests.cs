﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_11.Tests
{
    [TestClass]
    public class DuelOfWitsTests
    {
        [TestMethod]
        public void Main_WriteDizzyQuote()
        {
            const string expected = "\"Truly, you have a dizzying intellect.\"\n\"Wait 'til I get going!\"";

            IntelliTect.ConsoleView.Tester.Test(
                expected, DuelOfWits.Main);
        }
    }
}
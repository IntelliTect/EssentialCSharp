﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_08.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ObservingUnhandledExceptionsWithContinueWith()
        {
            string expected = "ERROR: Operation is not valid due to the current state of the object.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            () =>
            {
                Program.Main();
            });
        }
    }
}
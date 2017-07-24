﻿using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_23.Tests
{
    [TestClass]
    public class ThrowingExceptionsTests
    {
        [TestMethod]
        public void Main_WriteExecutionData()
        {
            string view =
@"Begin executing
Throw exception
Unexpected error: Arbitrary exception
Shutting down...";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(view,
            () =>
            {
                ThrowingExceptions.Main();
            });
        }
    }
}
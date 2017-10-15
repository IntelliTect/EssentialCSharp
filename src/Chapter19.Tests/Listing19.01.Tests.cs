using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_01.Tests
{
    [TestClass]
    public class ProgramTests
    {
        public static void TestUnsychronizedIncrementDecrement(Action action)
        {
            string expected = @"Count = *";

            string output = "";

            // Try 3 times just in case there is a fluk.
            for (int i = 0; i < 3; i++)
            {
                output = IntelliTect.TestTools.Console.ConsoleAssert.ExpectLike(expected,
                () =>
                {
                    action();
                });
                if (output != "Count = 0") break;
            }

            Assert.AreNotEqual<string>("Count = 0", output);
        }

        [TestMethod]
        public void UnsynchronizedIncrementAndDecrement()
        {
            TestUnsychronizedIncrementDecrement(Program.Main);
        }
    }
}

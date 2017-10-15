using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_03.Tests
{
    [TestClass]
    public class ProgramTests
    {
        public static void TestUnsychronizedIncrementDecrement(Action action)
        {
            string expected = @"Count = 0";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            () =>
            {
                action();
            });
        } 

        [TestMethod]
        public void SyncorhinzedIncrementAndDecrement()
        {
            TestUnsychronizedIncrementDecrement(Program.Main);
        }
    }
}

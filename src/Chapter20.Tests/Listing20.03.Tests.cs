using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_03.Tests
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

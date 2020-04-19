using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_27.Tests
{
    [TestClass]
    public class ThrowingExceptionsTests
    {
        [TestMethod]
        public void Main_ExpectException()
        {
            bool flag = false;

            try
            {
                IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                    "", ThrowingExceptions.Main);
            }
            catch (Exception)
            {
                flag = true;
            }

            Assert.IsTrue(flag);
        }
    }
}
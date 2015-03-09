using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_24.Tests
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
                IntelliTect.ConsoleView.Tester.Test(
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
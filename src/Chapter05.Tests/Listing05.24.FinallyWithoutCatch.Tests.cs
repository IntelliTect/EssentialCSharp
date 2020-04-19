using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_24.Tests
{
    [TestClass]
    public class ExceptionHandlingTests
    {
        [TestMethod]
        public void Main_InputInvalidAge_ExceptionCatching()
        {
            bool flag = false;
            string view =
@"<<Inigo
xyz
>>";

            try
            {
                IntelliTect.TestTools.Console.ConsoleAssert.Expect(view,
                () =>
                {
                    ExceptionHandling.Main();
                });
            }
            catch (FormatException)
            {
                flag = true;
            }

            Assert.IsTrue(flag);
        }
    }
}
using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_21.Tests
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
                Intellitect.ConsoleView.Tester.Test(view,
                () =>
                {
                    ExceptionHandling.ChapterMain();
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
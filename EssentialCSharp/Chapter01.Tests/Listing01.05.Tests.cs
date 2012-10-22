using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_05.Tests
{
    [TestClass]
    public class HelloWorldTests
    {
        [TestMethod]
        public void Main_UpDown()
        {
            string view =
            @"Up
Down";

            IntelliTect.ConsoleView.Tester.Test(view,
            () =>
            {
                HelloWorld.Main();
            });
        }
    }
}
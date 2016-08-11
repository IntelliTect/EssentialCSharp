using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_07.Tests
{
    [TestClass]
    public class HelloWorldTests
    {
        [TestMethod]
        public void Main_HelloToInigo()
        {
            const string expected = @"Hello Inigo Montoya";

            IntelliTect.ConsoleView.Tester.Test(
                expected, HelloWorld.ChapterMain);
        }
    }
}
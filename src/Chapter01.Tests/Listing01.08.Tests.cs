using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_08.Tests
{
    [TestClass]
    public class HelloWorldTests
    {
        [TestMethod]
        public void Main_HelloToInigo()
        {
            const string expected = @"Hello Inigo Montoya";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, HelloWorld.Main);
        }
    }
}
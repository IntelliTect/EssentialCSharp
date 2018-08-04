using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_06.Tests
{
    [TestClass]
    public class HelloWorldTests
    {
        [TestMethod]
        public void Main_UpDown()
        {
            const string expected =
@"Up
Down";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, HelloWorld.Main);
        }
    }
}
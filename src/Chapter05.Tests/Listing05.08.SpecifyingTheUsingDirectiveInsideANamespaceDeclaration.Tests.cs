using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_08.Tests
{
    [TestClass]
    public class HelloWorldTests
    {
        [TestMethod]
        public void Main_UsingToAvoidFullyQualifying_MethodCalledAsExpected()
        {
            const string expected =
                @"Hello, my name is Inigo Montoya";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, HelloWorld.Main);
        }
    }
}

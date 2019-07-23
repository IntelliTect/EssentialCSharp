using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_11.Tests
{
    [TestClass]
    public class HelloWorldTests
    {
        [TestMethod]
        public void Main_InigoMantra_ProperOutput()
        {
            const string expected =
@"My name is Inigo Montoya.
You killed my father....";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, HelloWorld.Main);
        }
    }
}
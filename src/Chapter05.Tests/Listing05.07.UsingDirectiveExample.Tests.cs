using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_07.Tests
{
    [TestClass]
    public class HelloWorldTests
    {
        [TestMethod]
        public void Main_WriteMyName()
        {
            string view = "Hello, my name is Inigo Montoya";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(view,
            () =>
            {
                HelloWorld.Main();
            });
        }
    }
}

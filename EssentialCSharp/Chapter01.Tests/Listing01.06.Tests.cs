using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_06.Tests
{
    [TestClass]
    public class HelloWorldTests
    {
        [TestMethod]
        public void Main_InigoHello()
        {
            string view = @"Hello. My name is Inigo Montoya.";

            IntelliTect.ConsoleView.Tester.Test(view,
            () =>
            {
                HelloWorld.Main();
            });
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_03.Tests
{

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ConnectingPublisherAndSubscribers()
        {
            string expected = @"Enter temperature: <<1";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            () =>
            {
                Program.Main();
            });
        }
    }
}
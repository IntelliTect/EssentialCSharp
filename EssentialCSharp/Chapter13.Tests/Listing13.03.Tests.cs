using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_03.Tests
{

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ConnectingPublisherAndSubscribers()
        {
            string expected = @"Enter temperature: <<1";

            IntelliTect.ConsoleView.Tester.Test(expected,
            () =>
            {
                Program.Main();
            });
        }
    }
}
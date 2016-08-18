using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_04.Tests
{
    using Listing13_04;

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void InvokingDelegateWithoutCheckingForNull()
        {
            string expected = @"Enter temperature: <<1>>Heater: On
Cooler: Off";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            () =>
            {
                Program.ChapterMain();
            });
        }
    }
}
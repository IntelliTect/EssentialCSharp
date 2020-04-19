using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.InteropServices;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter23.Listing23_20
{
    [TestClass]
    public class Listing21_20_Tests
    {

        [TestMethod]
        public void GetProcessorIdReturnsCorrectValue()
        {
            string expected = @"Processor Id: GenuineIntel";
            if (!System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                expected = "This sample is only valid for Windows";
            }

                IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            () =>
            {
                Program.Main();
            });
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.InteropServices;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter23.Listing23_20.Tests;
#if NET8_0_OR_GREATER
[TestClass]
public class Listing21_20_Tests
{
    [TestMethod]
    public void GetProcessorIdReturnsCorrectValue()
    {
        string expected = @"Processor Id: *";
        if (!System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            expected = "This sample is only valid for Windows";
        }
        IntelliTect.TestTools.Console.ConsoleAssert.ExpectLike(expected,
            () =>
            {
                Program.Main();
            });
    }
}
#endif
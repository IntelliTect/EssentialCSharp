using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_08.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        string expected = $@"Combine delegates using + operator:{Environment.NewLine}Heater: Off{Environment.NewLine}Cooler: Off{Environment.NewLine}Uncombine delegates using - operator:{Environment.NewLine}Heater: Off";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
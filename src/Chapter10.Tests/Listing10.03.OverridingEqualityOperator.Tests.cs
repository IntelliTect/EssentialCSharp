using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_03.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_GivenSerialNumbers_EqualityOverrideUsed()
        {
            const string expected = 
@"serialNumber1 reference equals serialNumber2
serialNumber1 equals serialNumber2
serialNumber1 equals serialNumber3";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}

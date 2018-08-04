using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_11.Tests
{
    [TestClass]
    public class DelegateSampleTests
    {
        [TestMethod]
        public void Main()
        {
            string expected =
            @"Enter an integer: <<1
>>Enter an integer: <<12
>>Enter an integer: <<13
>>Enter an integer: <<5
>>Enter an integer: <<4
>>1
12
13
4
5
";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            () =>
            {
                DelegateSample.Main();
            });
        }
    }
}
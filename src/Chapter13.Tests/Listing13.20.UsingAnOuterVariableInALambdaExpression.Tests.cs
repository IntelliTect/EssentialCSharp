using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_20.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main()
        {
            string expected =
            @"Enter an integer:<<5
>>Enter an integer:<<1
>>Enter an integer:<<4
>>Enter an integer:<<2
>>Enter an integer:<<3
>>5
4
3
2
1
Items were compared 10 times.
";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            () =>
            {
                Program.Main();
            });
        }
    }
}
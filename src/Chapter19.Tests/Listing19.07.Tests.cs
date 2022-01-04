using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_07.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod][Ignore]
        public void ValueTaskAsyncReturnTest()
        {
            string expected = @"3:0047:Throwing exception.
3:0052:Unhandled exception handler starting.
3:0055:Sleeping for 4000 ms
1:0058:Sleeping for 2000 ms
1:2059:Awake
1:2060:Finally block running.
3:4059:Awake
Unhandled Exception: System.Exception: Exception of type 'System.Exception' was thrown.
";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            () =>
            {
                Program.Main();
            });

        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_13
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_TryParseThreadLevelPriorityEnumToStringUsing()
        {
            const string expected = "Idle";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}

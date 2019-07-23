using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_23.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_OverflowIntegerUnchecked_NoException()
        {
            IntelliTect.TestTools.Console.ConsoleAssert.Execute("", Program.Main);
        }
    }
}
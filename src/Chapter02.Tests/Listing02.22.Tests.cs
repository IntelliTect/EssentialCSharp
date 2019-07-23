using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_22.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        [ExpectedException(typeof(System.OverflowException))]
        public void Main_IntegerOverFlow_ExceptionThrown()
        {
            IntelliTect.TestTools.Console.ConsoleAssert.Execute("", Program.Main);
        }
    }
}

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_28.Tests;

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

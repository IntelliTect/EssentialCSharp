
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_30.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_NotUsingTheCastOperatorForAnImplicitCast_NoException()
    {
        IntelliTect.TestTools.Console.ConsoleAssert.Execute("", Program.Main);
    }
}

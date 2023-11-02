
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_32.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_UsingIntParseToConvertAStringToANumericDataType_NoException()
    {
        IntelliTect.TestTools.Console.ConsoleAssert.Execute("", Program.Main);
    }
}

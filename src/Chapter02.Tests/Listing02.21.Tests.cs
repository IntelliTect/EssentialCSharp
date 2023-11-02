using System.Text.Json;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_21.Tests;

[TestClass]
public class RawLiteralTests
{
    [TestMethod]
    public void Main_OutputsJson()
    {
        string result = IntelliTect.TestTools.Console.ConsoleAssert.Execute("", Program.Main);
        Assert.IsNotNull(JsonDocument.Parse(result));
    }
}

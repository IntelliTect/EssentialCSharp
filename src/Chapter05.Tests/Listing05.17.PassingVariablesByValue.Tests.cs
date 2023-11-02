
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_17.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_WritePath()
    {
        string view = $"C:{Path.DirectorySeparatorChar}{Path.Combine("Data", "index.html")}";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(view,
        () =>
        {
            Program.Main();
        });
    }
}

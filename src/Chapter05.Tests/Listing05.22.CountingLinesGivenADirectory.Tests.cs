
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_22.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_WritePath()
    {
        string currentDirectory = Environment.CurrentDirectory;

        int expected = 0;
        foreach(string file in Directory.EnumerateFiles(currentDirectory, "*.cs"))
        {
            expected += File.ReadAllLines(file).Count(line => line.Trim().Length > 0);
        }

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected.ToString(),
        () =>
        {
            LineCounter.Main(new string[] { currentDirectory });
        });
    }
}

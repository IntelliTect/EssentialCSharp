using IntelliTect.TestTools.Console;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_07.Tests;

[TestClass]
public class ProgramTests
{
    // cSpell:ignore Linqs
    [TestMethod]
    public void ProjectionWithLinqsSelect()
    {
        int expectedItemCount = Directory.EnumerateFiles(
            Directory.GetCurrentDirectory(), "*").Count();
        string expectedPattern = $@"{ Directory.GetCurrentDirectory() }{Path.DirectorySeparatorChar}*";

        string output = IntelliTect.TestTools.Console.ConsoleAssert.Execute(null, () =>
        {
            Program.Main();
        });

        IEnumerable<string> outputItems = output.Split(
            new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

        Assert.AreEqual(expectedItemCount, outputItems.Count());
        foreach (string item in outputItems)
        {
            Assert.IsTrue(item.IsLike(expectedPattern));
        }
    }
}

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_09.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void DictionaryInitialization()
    {
        IntelliTect.TestTools.Console.ConsoleAssert.Execute(null,
        () =>
        {
            Program.Main();
        });
    }
}

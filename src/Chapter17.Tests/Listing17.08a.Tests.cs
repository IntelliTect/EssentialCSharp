using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_08a.Tests;

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

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_04.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void ObservingUnhandledExceptionsWithContinueWith()
    {
        string expected = "Task State: Completed";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
        () =>
        {
            Program.Main();
        });
    }
}
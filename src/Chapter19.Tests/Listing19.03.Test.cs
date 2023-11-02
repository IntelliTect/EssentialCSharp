
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_03.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void ObservingUnhandledExceptionsWithContinueWith()
    {
        string expected = @"Before
Starting...
Continuing A...
Continuing {0}...
Continuing {1}...
Finished!";
        string actual = IntelliTect.TestTools.Console.ConsoleAssert.Execute(expected,
        () =>
        {
            Program.Main();
        });

        Assert.IsTrue( 
            (string.Format(expected, 'B', 'C') == actual.TrimEnd()) || 
            (string.Format(expected, 'C', 'B') == actual.TrimEnd())
            );
    }
}
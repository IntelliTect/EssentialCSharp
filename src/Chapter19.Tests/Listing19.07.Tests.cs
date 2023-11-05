namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_07.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void ValueTaskAsyncReturnTest()
    {
        string expected =
@"Sleeping for 2000 ms
Throwing exception.
Event handler starting
Sleeping for 4000 ms
Awake
Finally block running.";

        string output = IntelliTect.TestTools.Console.ConsoleAssert.Execute(string.Empty,
        Program.Main).TrimEnd();

        // Assert that all expected lines are present.
        Assert.IsTrue(expected.Split(Environment.NewLine).All(output.Contains));

        // Assert that the thread ID (first number in each line) is not the same for all lines.
        Assert.AreEqual(2, output.Split(Environment.NewLine).Select(
            line => line.Split(':')[0]).Distinct().Count());
    }
}
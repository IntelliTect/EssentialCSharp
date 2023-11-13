namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Table04_04.Tests;

[TestClass]
public class ProgramTests
{
    private static void InvokeNullCheck(Action<string?> method, string uri)
    {
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            "Uri is null", ()=>method(null));

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            $"Uri is: {uri}", () => method(uri));
    }

    // 1.
    [TestMethod]
    public void PatternMatchingIsNullTest() =>
        InvokeNullCheck(Program.PatternMatchingIsNull, "NotNull");

    // 2.
    [TestMethod]
    public void PatternMatchingIsNotNullTest() =>
        InvokeNullCheck(Program.PatternMatchingIsNotNull, "NotNull");

    // 3.
    [TestMethod]
    public void EqualityInEqualityCheckForNullTest() =>
        InvokeNullCheck(Program.EqualityInEqualityCheckForNull, "NotNull");

    // 4.
    [TestMethod]
    public void IsObjectTest() =>
        InvokeNullCheck(Program.IsObject, "NotNull");

     // 5.
    [TestMethod]
    public void IsPatternMatchingTest() =>
        InvokeNullCheck(Program.IsPatternMatching, "NotNull");
    
     // 5.
    [TestMethod]
    public void ReferenceEqualsCheckForNotNullTest() =>
        InvokeNullCheck(Program.ReferenceEqualsCheckForNotNull, "NotNull");
}
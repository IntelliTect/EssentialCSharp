namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_36.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_ExpectHiddenAndReadOnlyFlags()
    {
        Directory.SetCurrentDirectory(AppContext.BaseDirectory);
        FileAttributes fileAttributes;
        string expected;

        fileAttributes = FileAttributes.Hidden | FileAttributes.ReadOnly;
        Assert.AreEqual<int>(3, (int)fileAttributes);
        expected = $@"ReadOnly, Hidden = {(int)fileAttributes}";

        
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}

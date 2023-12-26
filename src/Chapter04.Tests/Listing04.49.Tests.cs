
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_49.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_Input4_ValidInput()
    {
        const string expected =
            @"";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, () => Program.Main("4"));
    }
    
    [TestMethod]
    public void Main_Input0_InvalidInput()
    {
        const string expected = """
                ����:  ����1-9��ֵ��
                ��Enter���˳���
                """;

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, () => Program.Main("0"));
    }
    
    [TestMethod]
    public void Main_InputQuit_ExitProgram()
    {
        const string expected =
            @"";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, () => Program.Main("quit"));
    }
}

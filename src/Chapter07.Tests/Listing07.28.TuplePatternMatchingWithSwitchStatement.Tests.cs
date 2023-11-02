using AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_27.Tests;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_28.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public async Task Main_EncryptFileUsingSwitchStatement_Success()
    {
        await TuplePatternMatchingTests.InvokeMainWithEncriptAction(
            Program.Main);
    }

    [TestMethod]
    public async Task Main_ShowFileWithSwitchStatement_Success()
    {
        await TuplePatternMatchingTests.InvokeMainWithShowFile(Program.Main);
    }
}

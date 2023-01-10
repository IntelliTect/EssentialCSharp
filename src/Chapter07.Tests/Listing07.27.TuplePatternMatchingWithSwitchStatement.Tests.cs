using AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_26.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_27.Tests;

[TestClass]
public class ProgramTests
{
    string DataFile = "data.dat";
    const string EncryptedFileName = "temp.out";

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

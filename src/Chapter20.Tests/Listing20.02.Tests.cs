using AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Tests;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_02.Tests;

[TestClass]
public class ProgramTests : BaseProgramTests
{
    [ClassInitialize]
    public static void ClassInitialize(TestContext _)
    {
        Program.HttpClient = GetMockedHttpClient();
        ProgramWrapper = new ProgramWrapper(
            (args) =>
                Task.Run(() => Program.Main(args)));
    }

    protected override string DefaultUrl { get; } = Program.DefaultUrl;
}

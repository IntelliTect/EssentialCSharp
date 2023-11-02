using AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Tests;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_03.Tests;

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

    protected override void AssertMainException(string messagePrefix,Exception exception)
    {
        AssertMainException(messagePrefix, (AggregateException)exception);
    }

    protected override string DefaultUrl => Program.DefaultUrl;
}

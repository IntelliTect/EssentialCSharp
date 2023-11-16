using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;
using System.Diagnostics.CodeAnalysis;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_02.Tests;

[TestClass]
public class UppercaseTests
{
    [NotNull]
    public TestContext? TestContext { get; set; }

    [TestMethod]
    public async Task UnassignedVariableThrowsError()
    {
        await CompilerAssert.CompileTestTargetFileAsync(
            ["CS0165", "CS8602"]);
    }
}
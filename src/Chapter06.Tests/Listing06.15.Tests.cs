using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection.Emit;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_15.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public async Task UnassignedVariableThrowsError()
    {
        await CompilerAssert.CompileAsync(
            "Listing06.15.UsingThePrivateAccessModifier.cs",
            "CS0122");

    }
}
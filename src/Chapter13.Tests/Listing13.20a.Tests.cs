using Microsoft.VisualStudio.TestTools.UnitTesting;
using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_20a.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public async Task StaticAnonymousFunctionBehavior()
    {
        await CompilerAssert.CompileAsync(
            new string[] { "Listing13.20a.StaticAnonymousFunctions.cs",
                "Listing13.11.UsingADifferentFuncCompatibleMethod.cs"},
            new string[] { "CS8820" } );
    }
}
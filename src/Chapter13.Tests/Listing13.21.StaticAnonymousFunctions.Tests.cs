using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_21.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public async Task StaticAnonymousFunctionBehavior()
    {
        await CompilerAssert.CompileAsync(
            new string[] { "Listing13.21.StaticAnonymousFunctions.cs",
                "Listing13.11.UsingADifferentFuncCompatibleMethod.cs"},
            new string[] { "CS8820" } );
    }
}

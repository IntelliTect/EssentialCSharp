using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_39.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public async Task NotSpecifyingRequiredMembersWithinTheObjectInitializer()
    {
#if NET7_0_OR_GREATER
        await CompilerAssert.CompileAsync(
            new string[]{
                "Listing06.39.SpecifyingRequiredMembersWithinTheObjectInitializer.cs",
                "Listing06.38.RequiredProperties.cs" },
            new string[] { "CS9035" });
#endif //NET7_0_OR_GREATER
    }
}

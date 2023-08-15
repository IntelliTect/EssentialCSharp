using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_16.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public async Task DefiningAnAbstractClass()
    {
        await CompilerAssert.CompileAsync(
            new string[] { $"{
                nameof(Listing07_16)
                    .Replace('_','.')}.{
                nameof(DefiningAnAbstractClass)}.cs" },
            new string[] { "CS0144" });
    }
}

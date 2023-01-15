using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_07.Tests;

[TestClass]
public class ContactTests
{
    [TestMethod]
    public async Task DeclaringAMethodOnARelatedInterface_CompileError()
    {
        await CompilerAssert.CompileAsync(
            new string[] { "Listing08.07.DeclarationWithoutContainingInterface.cs" },
            new string[] { "CS0161", "CS0540" });
    }
}

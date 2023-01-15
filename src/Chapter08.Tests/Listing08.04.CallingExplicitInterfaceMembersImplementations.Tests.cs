using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_04.Tests;

[TestClass]
public class ContactTests
{
    [TestMethod]
    public async Task InvokingExplicitInterfaceMemberWithoutCast_CompileError()
    {
        await CompilerAssert.CompileAsync(
            new string[] { "Listing08.04.CallingExplicitInterfaceMemberImplementations.cs", "Listing08.02.ImplementingAndUsingInterfaces.cs" },
            new string[] { "CS1061" });
    }
}

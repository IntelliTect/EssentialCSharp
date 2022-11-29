using AddisonWesley.Michaelis.EssentialCSharp.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_21.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        async public Task UnassignedVariableThrowsError()
        {
            _ = await CompilerAssert.ExpectErrorsInFileAsync(
                "Listing06.21.DefiningReadOnlyProperties.cs",
                new CompileError("CS0200", "Property or indexer 'Employee.Id' cannot be assigned to -- it is read only"));
        }
    }
}
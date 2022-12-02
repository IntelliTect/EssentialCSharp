using AddisonWesley.Michaelis.EssentialCSharp.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_23.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public async Task UnassignedVariableThrowsError()
        {
            _ = await CompilerAssert.ExpectErrorsInFileAsync(
                "Listing06.23.PlacingAccessModifiersOnSetters.cs",
                new CompileError("CS0272", "The property or indexer 'Employee.Id' cannot be used in this context because the set accessor is inaccessible"));
        }
    }
}
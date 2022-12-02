using AddisonWesley.Michaelis.EssentialCSharp.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection.Emit;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_15.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public async Task UnassignedVariableThrowsError()
        {
            _ = await CompilerAssert.ExpectErrorsInFileAsync(
                "Listing06.15.UsingThePrivateAccessModifier.cs",
                new CompileError("CS0122", "'Employee.Password' is inaccessible due to its protection level"));

        }
    }
}
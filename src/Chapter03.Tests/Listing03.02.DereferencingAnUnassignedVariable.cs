using AddisonWesley.Michaelis.EssentialCSharp.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_02
{
    [TestClass]
    public class UppercaseTests
    {
        [NotNull]
        public TestContext? TestContext { get; set; }

        [TestMethod]
        async public Task UnassignedVariableThrowsError()
        {
            CompileError[] compileErrors = await CompilerAssert.ExpectErrorsInFileAsync(
                "Listing03.02.DereferencingAnUnassignedVariable.cs",
                new CompileError("CS0165: Use of unassigned local variable 'text'"));
        }
    }
}

using AddisonWesley.Michaelis.EssentialCSharp.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_01B.Tests
{
    [TestClass]
    public class UppercaseTests
    {
        public TestContext? TestContext { get; set; }

        [TestMethod]
        async public Task UnassignedVariableThrowsError()
        {
            CompileError[] compileErrors = await CompilerAssert.ExpectErrorsInFileAsync(
                "Listing03.01B.DereferencingAnUnassignedVariable.cs",
                new CompileError("CS0165: Use of unassigned local variable 'text'"));
        }
    }
}
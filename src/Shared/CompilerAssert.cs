using Microsoft.CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.CodeAnalysis;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable enable
namespace AddisonWesley.Michaelis.EssentialCSharp.Shared
{
    readonly public struct CompileError
    {
        public string Id { get; }
        public string Message { get; }

        public CompileError(string id, string message)
        {
            Id = id;
            Message = message;
        }
        public void Deconstruct(out string id, out string message)
        {
            (id, message) = (Id, Message);
        }
    }
    static public class CompilerAssert
    {
        async static public Task ExpectErrorsAsync(string sourceCode, params CompileError[] diagnostics)
        {
            try
            {
                await CSharpScript.EvaluateAsync(sourceCode);
            }
            catch(CompilationErrorException exception)
            {
                Assert.IsTrue(exception.Diagnostics.Length > 0);
                if(diagnostics is { } && diagnostics.Length >0)
                {
                    CompileError[] actualCompileErrors = exception.Diagnostics.Select(item =>
                        new CompileError(item.Id, item.GetMessage())).ToArray();

                    Assert.AreEqual<int>(diagnostics.Length, actualCompileErrors.Length,
                        "The number of errors returned does not match what was expected.");

                    for (int i = 0; i < actualCompileErrors.Length; i++)
                    {
                        Assert.AreEqual<string>(diagnostics[i].Id, diagnostics[i].Id,
                            $"The expected Ids do not match for item {i}: " +
                            $"{diagnostics[i].Id} <> {diagnostics[i].Id}");
                        Assert.AreEqual<string>(diagnostics[i].Message, actualCompileErrors[i].Message,
                            $"The expected Messages do not match for item {i}: " +
                            $"{diagnostics[i].Message} <> {diagnostics[i].Message}");
                    }
                    //CollectionAssert.AreEquivalent(
                    //    diagnostics, 
                    //    actualCompileErrors.ToList());
                }
            }
            Assert.Fail("The expected compilation errors did not occur.");
        }
    }
}

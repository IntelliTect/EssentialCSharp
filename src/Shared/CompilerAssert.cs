using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

#nullable enable
namespace AddisonWesley.Michaelis.EssentialCSharp.Shared
{
    readonly public struct CompileError
    {
        public string Id { get; }
        public string Message { get; }

        public CompileError(string fullMessage)
        {
            string[] parts = fullMessage.Split(": ");
            if(parts.Length != 2)
            {
                throw new ArgumentException(
                    "Message is not of the form Id: Message", nameof(fullMessage));
            }
            Id = parts[0];
            Message = parts[1];
        }
        public CompileError(string id, string message)
        {
            Id = id;
            Message = message;
        }
        public void Deconstruct(out string id, out string message)
        {
            (id, message) = (Id, Message);
        }
        public override string ToString()
        {
            return $"{Id}: {Message}";
        }

        // override object.Equals
        public override bool Equals(object? obj)
        {
            return (obj is CompileError)
              && Equals((CompileError)obj);
        }

        // Implemented IEquitable<T>
        public bool Equals(CompileError rhs)
        {
            return (Id, Message).Equals(
              (rhs.Id, rhs.Message));
        }


        // override object.GetHashCode
        public override int GetHashCode() =>
            (Id, Message).GetHashCode();


        public static bool operator ==(
            CompileError lhs, CompileError rhs) =>
                lhs.Equals(rhs);

        public static bool operator !=(
            CompileError lhs, CompileError rhs) =>
                !lhs.Equals(rhs);
    }
    static public class CompilerAssert
    {
        async static public Task<CompileError[]> ExpectErrorsAsync(
            string sourceCode, params CompileError[] diagnostics)
        {
            try
            {
                await CSharpScript.EvaluateAsync(sourceCode);
            }
            catch(CompilationErrorException exception)
            {
                Assert.IsTrue(exception.Diagnostics.Length > 0);

                CompileError[] actualCompileErrors;
                actualCompileErrors = exception.Diagnostics.Select(item =>
                    new CompileError(item.Id, item.GetMessage())).ToArray();

                if (diagnostics is { } && diagnostics.Length > 0)
                {
                    Assert.AreEqual<int>(diagnostics.Length, actualCompileErrors.Length,
                        "The number of errors returned does not match what was expected.");

                    for (int i = 0; i < actualCompileErrors.Length; i++)
                    {
                        // Compare Id's first as that is more meaningful.
                        Assert.AreEqual<string>(diagnostics[i].Message, actualCompileErrors[i].Message,
                            $"The expected Messages do not match for item {i}: " +
                            $"{diagnostics[i].Message} <> {diagnostics[i].Message}");
                        Assert.AreEqual<string>(diagnostics[i].Id, actualCompileErrors[i].Id,
                            $"The expected Ids do not match for item {i}: " +
                            $"{diagnostics[i].Id} <> {actualCompileErrors[i].Id}");
                    }
                    //CollectionAssert.AreEquivalent(
                    //    diagnostics, 
                    //    actualCompileErrors.ToList());
                }
                return actualCompileErrors;
            }
            Assert.Fail("The expected compilation errors did not occur.");
            return null!;  // This code will never execute due to the Fail line above.
        }
    }
}

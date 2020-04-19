using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AddisonWesley.Michaelis.EssentialCSharp.Shared
{
    public class SampleClass
    {
        public static void ReturnVoidNoParameters() { }
        public static void ReturnVoidArgsArrayParameter(string[] args) { }
        public static int ReturnIntNoParameters() => 42;

        public static int ReturnIntArgsArrayParameter(string[] args) => 42;
        public static async Task ReturnTaskArgsArrayParameter(string[] args) => await Task.Run(() => { });
        public static async Task<int> ReturnTaskOfIntArgsArrayParameter(string[] args) => await Task.Run(() => 42);
        public static async Task<string> ReturnTaskOfStringArgsArrayParameter(string[] args) => await Task.Run(() => "forty-two");
        public static async Task<object?> ReturnTaskOfNullableObjectArgsArrayParameter(string[] args) => await Task.Run(() => (object)"42");
        public static async Task<int> ReturnValueTaskOfIntArgsArrayParameter(string[] args) => await Task.Run(() => 42);
        public static async Task<string> ReturnValueTaskOfStringArgsArrayParameter(string[] args) => await Task.Run(() => "forty-two");
        public static async Task<object?> ReturnValueTaskOfNullableObjectArgsArrayParameter(string[] args) => await Task.Run(() => (object)"42");

        public static async IAsyncEnumerable<string> ReturnIAsyncEnumerableOfStringArgsArrayParameter(string[] args)
        {
            foreach (string item in args)
            {
                yield return await Task.Run(()=>item);
            }
            
        }
    }

    [TestClass]
    public class ProgramTests
    {
        [DataRow(nameof(SampleClass.ReturnVoidNoParameters), null, null)]
        [DataRow(nameof(SampleClass.ReturnVoidArgsArrayParameter), new string[] { "One" }, null)]
        [DataRow(nameof(SampleClass.ReturnIntNoParameters), null, "42")]
        [DataRow(nameof(SampleClass.ReturnIntArgsArrayParameter), new string[] { "One" }, "42")]
        [DataRow(nameof(SampleClass.ReturnTaskArgsArrayParameter), new string[] { "One" }, null)]
        [DataRow(nameof(SampleClass.ReturnTaskOfIntArgsArrayParameter), new string[] { "One" }, "42")]
        [DataRow(nameof(SampleClass.ReturnTaskOfStringArgsArrayParameter), new string[] { "One" }, "forty-two")]
        [DataRow(nameof(SampleClass.ReturnTaskOfNullableObjectArgsArrayParameter), new string[] { "One" }, (object)"42")]
        [DataRow(nameof(SampleClass.ReturnValueTaskOfIntArgsArrayParameter), new string[] { "One" }, "42")]
        [DataRow(nameof(SampleClass.ReturnValueTaskOfStringArgsArrayParameter), new string[] { "One" }, "forty-two")]
        [DataRow(nameof(SampleClass.ReturnValueTaskOfNullableObjectArgsArrayParameter), new string[] { "One" }, (object)"42")]
        [DataRow(nameof(SampleClass.ReturnIAsyncEnumerableOfStringArgsArrayParameter), 
            new string[] { "1","2","3" }, "1, 2, 3")]
        [TestMethod]
        public async Task InvokeMethodUsingReflection(string methodName, string[]? args, string? expected)
        {
            Assert.AreEqual<string?>(expected,
                await Program.InvokeMethodUsingReflection(
                    typeof(SampleClass).GetMethod(methodName)!, args));
        }
    }
}
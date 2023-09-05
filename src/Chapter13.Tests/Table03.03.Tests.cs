using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Table03_03.Tests;

[TestClass]
public class ArrayHighlightsTests
{
    public TestContext TestContext { get; set; } = null!; // Set by MSTest;

#if !NET6_0_OR_GREATER
    [TestMethod]
    /* 1. */ [DataRow(".a", "CS8773")]
    ///* 2. */ [DataRow(".b", "CS1525", "CS1002", "CS1002", "CS1513", "CS1002", "CS1513", "CS1002")]
    ///* 3. */ [DataRow(".c", "CS0270")]
    ///* 4. */ [DataRow(".d", "CS1586")]
    ///* 5. */ [DataRow(".e", "CS0847")]
    ///* 9. */ [DataRow(".i", "CS0847")]
    public async Task ParseAndCompile(string fileNameSuffix, params string[] errorIds)
    {
        await CompilerAssert.CompileAsync($"Table13.01{fileNameSuffix}.LambdaExpressionNotesAndExamples.cs", errorIds);
    }
    #endif // !NET6_0_OR_GREATER
    // 6.
    //[TestMethod]
    //[ExpectedException(typeof(IndexOutOfRangeException))]
    //public void IndexingOffTheEndOfArrayTest()
    //{
    //    CommonArayCodingErrors.IndexingOffTheEndOfArray();
    //}

    // 7.
    //[TestMethod]
    //[ExpectedException(typeof(IndexOutOfRangeException))]
    //public void Hat0IsOnePastTheEndOfTheArray1Test()
    //{
    //    CommonArayCodingErrors.Hat0IsOnePastTheEndOfTheArray1();
    //}

    // 8.
    //[TestMethod]
    //[ExpectedException(typeof(IndexOutOfRangeException))]
    //public void Hat0IsOnePastTheEndOfTheArray2Test()
    //{
    //    CommonArayCodingErrors.LastItemIsLengthMinus1();
    //}
}
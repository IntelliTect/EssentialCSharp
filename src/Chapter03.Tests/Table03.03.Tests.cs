using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Table03_03.Tests;

[TestClass]
public class ArrayHighlightsTests
{
    [TestMethod]
    /* 1. */ [DataRow(".a", "CS0650")]
    /* 2. */ [DataRow(".b", "CS1525", "CS1002", "CS1002", "CS1513", "CS1002", "CS1513", "CS1002")]
    /* 3. */ [DataRow(".c", "CS0270")]
    /* 4. */ [DataRow(".d", "CS1586")]
    /* 5. */ [DataRow(".e", "CS0847")]
    /* 9. */ [DataRow(".i", "CS0847")]
    public async Task ParseAndCompile(string fileNameSuffix, params string[] errorIds)
    {
        await CompilerAssert.CompileAsync($"Table03.03{fileNameSuffix}.CommonArrayCodingErrors.cs", errorIds);
    }

    // 6.
    [TestMethod]
    [ExpectedException(typeof(IndexOutOfRangeException))]
    public void IndexingOffTheEndOfArrayTest()
    {
        CommonArrayCodingErrors.IndexingOffTheEndOfArray();
    }

    // 7.
    [TestMethod]
    [ExpectedException(typeof(IndexOutOfRangeException))]
    public void Hat0IsOnePastTheEndOfTheArray1Test()
    {
        CommonArrayCodingErrors.Hat0IsOnePastTheEndOfTheArray1();
    }

    // 8.
    [TestMethod]
    [ExpectedException(typeof(IndexOutOfRangeException))]
    public void Hat0IsOnePastTheEndOfTheArray2Test()
    {
        CommonArrayCodingErrors.LastItemIsLengthMinus1();
    }
}
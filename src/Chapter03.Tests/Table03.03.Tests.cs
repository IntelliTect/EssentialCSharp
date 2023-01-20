using AddisonWesley.Michaelis.EssentialCSharp.Shared;
using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Table03_03.Tests;

[TestClass]
public class ArrayHighlightsTests
{
    public TestContext TestContext { get; set; } = null!; // Set by MSTest;

    private const string FileName = "Table03.03.CommonArrayCodingErrors.cs";

    [TestMethod]
    /* 1. */ [DataRow(nameof(CommonArayCodingErrors.SquareBracketsOnVariableRatherThanType), "CS0650")]
    /* 2. */ [DataRow(nameof(CommonArayCodingErrors.NewKeywordWithDataTypeRequired), "CS1525", "CS1002", "CS1002", "CS1513", "CS1002", "CS1513", "CS1002")]
    /* 3. */ [DataRow(nameof(CommonArayCodingErrors.ArraySizeCannotBeSpecifiedInDataType), "CS0270")]
    /* 4. */ [DataRow(nameof(CommonArayCodingErrors.ArraySizeOrInitializerIsRequired), "CS1586")]
    /* 5. */ [DataRow(nameof(CommonArayCodingErrors.ArraySizeWithEmptyInitializer), "CS0847")]
    /* 9. */ [DataRow(nameof(CommonArayCodingErrors.MultiDimensionalArrayWithInconsistentSize), "CS0847")]
    public async Task ParseAndCompile(string targetMethod, params string[] errorIds)
    {
        // TODO: await CompilerAssert.CompileAsync("Table03.03.CommonArrayCodingErrors.cs", errorIds,)
        await CompilerAssertOld.Compile2Async("Table03.03.CommonArrayCodingErrors.cs", errorIds, targetMethod);
    }

    // 6.
    [TestMethod]
    [ExpectedException(typeof(IndexOutOfRangeException))]
    public void IndexingOffTheEndOfArrayTest()
    {
        CommonArayCodingErrors.IndexingOffTheEndOfArray();
    }

    // 7.
    [TestMethod]
    [ExpectedException(typeof(IndexOutOfRangeException))]
    public void Hat0IsOnePastTheEndOfTheArray1Test()
    {
        CommonArayCodingErrors.Hat0IsOnePastTheEndOfTheArray1();
    }

    // 8.
    [TestMethod]
    [ExpectedException(typeof(IndexOutOfRangeException))]
    public void Hat0IsOnePastTheEndOfTheArray2Test()
    {
        CommonArayCodingErrors.LastItemIsLengthMinus1();
    }
}
using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Table13_01.Tests;

[TestClass]
public class LambdaHighlightTests
{
    public TestContext TestContext { get; set; } = null!; // Set by MSTest;

    [TestMethod]
    /* 1. */ [DataRow(".a", "CS0023")]
    /* 2. */ [DataRow(".b", "CS0837")]
    /* 3. */ [DataRow(".c", "CS0029", "CS1662")]
    /* 5. */ [DataRow(".e", "CS8070", "CS1632")]
    /* 6. */ [DataRow(".f", "CS0103")]
    /* 7. */ [DataRow(".g", "CS0165")]
    /* 8. */ [DataRow(".h", "CS0165")]
    public async Task ParseAndCompile(string fileNameSuffix, params string[] errorIds)
    {
        await CompilerAssert.CompileAsync($"Table13.01{fileNameSuffix}.LambdaExpressionNotesAndExamples.cs", errorIds);
    }

    [TestMethod]
    public void PatternMatchingOnTypeTest(){
        LambdaExpressionNotesAndExamples.PatternMatchingOnType();
    }
}
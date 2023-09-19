using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Table13_01.Tests;

[TestClass]
public class LambdaHighlightTests
{
    public TestContext TestContext { get; set; } = null!; // Set by MSTest;

    [TestMethod]
    /* 1. */ [DataRow(".a")]
    /* 2. */ [DataRow(".b")]
    /* 3. */ [DataRow(".c")]
    /* 4. */ [DataRow(".d")]
    /* 5. */ [DataRow(".e")]
    /* 6. */ [DataRow(".f")]
    /* 7. */ [DataRow(".g")]
    /* 8. */ [DataRow(".h")]
    /* 9. */ [DataRow(".i")]
    /* 10. */ [DataRow(".j")]
    public async Task ParseAndCompile(string fileNameSuffix, params string[] errorIds)
    {
        await CompilerAssert.CompileAsync($"Table13.01{fileNameSuffix}.LambdaExpressionNotesAndExamples.cs", errorIds);
    }
}
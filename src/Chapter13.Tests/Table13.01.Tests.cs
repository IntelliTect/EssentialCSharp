using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Table13_01.Tests;

[TestClass]
public class LambdaHighlightTests
{

    [TestMethod]
    /* 1. */ [DataRow(".a")]
    /* 2. */ [DataRow(".b")]
    /* 3. */ [DataRow(".c")]
    /* 4. */ [DataRow(".d", "CS0023")]
    /* 5. */ [DataRow(".e", "CS0837")]
    /* 6. */ [DataRow(".f", "CS0029", "CS1662")]
    /* 7. */ [DataRow(".g", "CS8070", "CS1632")]
    /* 8. */ [DataRow(".h", "CS0103")]
    /* 9. */ [DataRow(".i", "CS0165")]
    /* 10. */ [DataRow(".j", "CS0165")]
    public async Task ParseAndCompile(string fileNameSuffix, params string[] errorIds)
    {
        await CompilerAssert.CompileAsync($"Table13.01{fileNameSuffix}.LambdaExpressionNotesAndExamples.cs", errorIds);
    }
}
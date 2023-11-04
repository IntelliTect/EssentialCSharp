// Justification: Only snippets of source code shown for elucidation.
#pragma warning disable CS0168 // Variable is declared but never used

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Table13_01;

public partial class LambdaExpressionNotesAndExamples
{
    // 2.
    public static void TypeInferenceOfExpression()
    {
#if NET6_0_OR_GREATER
        //You can assign lambda
        //expression to an implicitly
        //typed local variable starting C#10
        var v = (int x) => x;
#endif
    }
}

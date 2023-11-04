// Justification: Only snippets of source code shown for elucidation.
#pragma warning disable CS0168 // Variable is declared but never used

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Table13_01;

public partial class LambdaExpressionNotesAndExamples
{
    // 3.
    public static void ExpressionsCanHaveReturnTypes()
    {
#if NET6_0_OR_GREATER
        Action action = void () => { };
        var func = short?(long number) => 
            number <= short.MaxValue ? (short)number : null;
#endif
    }
}

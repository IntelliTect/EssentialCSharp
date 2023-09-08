// Justification: Only snippets of source code shown for elucidation.
#pragma warning disable CS0168 // Variable is declared but never used

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Table13_01;

public partial class LambdaExpressionNotesAndExamples
{
    // 6.
    static public void AccessingParametersAndLocalsOutOfBody()
    {
//#if COMPILEERROR
#if !NET6_0_OR_GREATER
    //ERROR: The name "first" does not
    //exist in the current context
    Func <int, int, bool> expression =
        (first, secont) => first > second;
    first++;
#endif
//#endif // COMPILEERROR
    }
}

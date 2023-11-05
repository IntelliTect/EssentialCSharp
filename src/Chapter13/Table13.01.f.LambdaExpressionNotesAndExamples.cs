// Justification: Only snippets of source code shown for elucidation.
#pragma warning disable CS0168 // Variable is declared but never used

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Table13_01;

public partial class LambdaExpressionNotesAndExamples
{
    // 6.
    public static void ConvertingToImproperDelegate()
    {
        #if COMPILEERROR
        //ERROR: Lambda expression is not compatible
        //with Func<int, bool> type
        Func<int, bool> f = (int x) => x;
        #endif // COMPILEERROR
    }
}

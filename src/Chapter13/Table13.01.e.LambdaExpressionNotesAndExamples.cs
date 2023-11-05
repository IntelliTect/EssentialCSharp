// Justification: Only snippets of source code shown for elucidation.
#pragma warning disable CS0168 // Variable is declared but never used

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Table13_01;

public partial class LambdaExpressionNotesAndExamples
{
    // 5.
    public static void PatternMatchingOnType()
    {
        #if COMPILEERROR
        //ERROR: The first operand of an "is" or "as"
        //operator may not be a lambda expression or
        //anonymous method
        bool b = ((int x) => x) is Func<int,int>;
        #endif // COMPILEERROR
    }
}

// Justification: Only snippets of source code shown for elucidation.
#pragma warning disable CS0168 // Variable is declared but never used

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Table13_01;

public partial class LambdaExpressionNotesAndExamples
{
    // 4.
    static public void MemberMethodsOnExpressions()
    {
    //#if COMPILEERROR
    #if !NET6_0_OR_GREATER
        //ERROR: Operator "." cannot be applied to
        //operand of type "lambda expression"
        string s = ((int x) => x).ToString();
    #endif
    //#endif // COMPILEERROR
    }
}

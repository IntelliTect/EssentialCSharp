// Justification: Only snippets of source code shown for elucidation.
#pragma warning disable CS0168 // Variable is declared but never used

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Table13_01;

public partial class LambdaExpressionNotesAndExamples
{
    // 4.
    public static void MemberMethodsOnExpressions()
    {
        #if COMPILEERROR
        //ERROR: Operator "." cannot be applied to
        //operand of type "lambda expression"
        string s = ((int x) => x).ToString();
        #endif // COMPILEERROR
    }
}

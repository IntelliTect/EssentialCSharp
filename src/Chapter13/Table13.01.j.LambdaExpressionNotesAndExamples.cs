// Justification: Only snippets of source code shown for elucidation.
#pragma warning disable CS0168 // Variable is declared but never used

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Table13_01;

public partial class LambdaExpressionNotesAndExamples
{
    // 10.
    public static void CompilerWillNotDetectInLambdaAssignment()
    {
        #if COMPILEERROR
        int number;
        Func<int, bool> isFortyTwo =
          x => 42 == (number = x);
        if (isFortyTwo(42))
        {
            // ERROR: Use of unassigned local variable
            System.Console.Write(number);
        }
        #endif // COMPILEERROR
    }
}

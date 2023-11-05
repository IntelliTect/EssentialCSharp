// Justification: Only snippets of source code shown for elucidation.
#pragma warning disable CS0168 // Variable is declared but never used

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Table13_01;

public partial class LambdaExpressionNotesAndExamples
{
    // 1.
    public static void DiscardParameters()
    {
#if NET5_0_OR_GREATER
        Action<int, int> x = (_, _)=>
            Console.WriteLine("This is a test.");
#endif
    }
}

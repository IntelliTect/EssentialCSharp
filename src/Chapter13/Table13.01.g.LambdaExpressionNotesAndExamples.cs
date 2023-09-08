// Justification: Only snippets of source code shown for elucidation.
#pragma warning disable CS0168 // Variable is declared but never used

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Table13_01;

public partial class LambdaExpressionNotesAndExamples
{
    // 7.
    static public void UsingOutParameters()
    {
//#if COMPILEERROR
#if !NET6_0_OR_GREATER
    int number;
    Func <string, bool> f =
        text => int.TryParse(text, out number);
    if (f("1"))
    {
      //ERROR: Use of unassigned local variable
        System.Console.Write(number)
    }
#endif
//#endif // COMPILEERROR
    }
}

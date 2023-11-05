// Justification: Only snippets of source code shown for elucidation.
#pragma warning disable CS0168 // Variable is declared but never used

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Table13_01;

public partial class LambdaExpressionNotesAndExamples
{
    // 9.
    public static void UsingOutParameters()
    {
    #if COMPILEERROR
    int number;
    Func <string, bool> f =
        text => int.TryParse(text, out number);
    if (f("1"))
    {
      //ERROR: Use of unassigned local variable
        System.Console.Write(number);
    }
    #endif // COMPILEERROR
    }
}

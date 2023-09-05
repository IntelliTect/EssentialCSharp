// Justification: Only snippets of source code shown for elucidation.
#pragma warning disable CS0168 // Variable is declared but never used

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Table13_01;

public partial class CommonArayCodingErrors
{
    // 1.
    static public void SquareBracketsOnVariableRatherThanType()
    {
//#if COMPILEERROR
#if !NET6_0_OR_GREATER
        var v = (int x) => x;
#endif
//#endif // COMPILEERROR
    }
}

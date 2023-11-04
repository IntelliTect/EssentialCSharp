// Justification: Only snippets of source code shown for elucidation.
#pragma warning disable CS0168 // Variable is declared but never used

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Table03_03;

public partial class CommonArrayCodingErrors
{
    // 2.
    public static void NewKeywordWithDataTypeRequired()
    {
#if COMPILEERROR
        int[] numbers;
        numbers = {42, 84, 168 };
#endif // COMPILEERROR
    }
}

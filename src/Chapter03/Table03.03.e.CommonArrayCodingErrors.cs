// Justification: Only snippets of source code shown for elucidation.
#pragma warning disable CS0168 // Variable is declared but never used

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Table03_03;

public partial class CommonArrayCodingErrors
{
    // 5.
    public static void ArraySizeWithEmptyInitializer()
    {
#if COMPILEERROR
        int[] numbers =
            new int[3] { };
#endif // COMPILEERROR
    }
}

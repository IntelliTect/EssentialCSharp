// Justification: Only snippets of source code shown for elucidation.
#pragma warning disable CS0168 // Variable is declared but never used

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Table03_03;

public partial class CommonArrayCodingErrors
{
    // 9.
    public static void MultiDimensionalArrayWithInconsistentSize()
    {
#if COMPILEERROR
        int[,] numbers =
          { {42}, {84, 42} };
#endif // COMPILEERROR
    }
}

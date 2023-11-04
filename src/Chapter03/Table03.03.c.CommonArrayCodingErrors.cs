// Justification: Only snippets of source code shown for elucidation.
#pragma warning disable CS0168 // Variable is declared but never used

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Table03_03;

public partial class CommonArrayCodingErrors
{
    // 3.
    public static void ArraySizeCannotBeSpecifiedInDataType()
    {
#if COMPILEERROR
        int[3] numbers = 
            { 42, 84, 168 };
#endif // COMPILEERROR
    }
}

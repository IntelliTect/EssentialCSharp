// Justification: Only snippets of source code shown for elucidation.
#pragma warning disable CS0168 // Variable is declared but never used

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Table03_03
{
    public partial class CommonArayCodingErrors
    {
        // 5.
        static public void ArraySizeWithEmptyInitializer()
        {
#if COMPILEERROR
            int[] numbers =
                new int[3] { };
#endif // COMPILEERROR
        }
    }
}

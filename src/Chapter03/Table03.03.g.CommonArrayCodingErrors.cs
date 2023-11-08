// Justification: Only snippets of source code shown for elucidation.
#pragma warning disable CS0168 // Variable is declared but never used

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Table03_03;

public partial class CommonArrayCodingErrors
{
    // 7.
    public static void Hat0IsOnePastTheEndOfTheArray1()
    {
        int[] numbers =
          new int[3];
        numbers[^0] = 42;
    }
}

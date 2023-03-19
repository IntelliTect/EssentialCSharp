// Justification: Only snippets of source code shown for elucidation.
#pragma warning disable CS0168 // Variable is declared but never used

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Table03_03;

public class CommonArayCodingErrors
{
    // 1.
    static public void SquareBracketsOnVariableRatherThanType()
    {
#if INCLUDE
        int numbers[];
#endif // INCLUDE
    }

    // 2.
    static public void NewKeywordWithDataTypeRequired()
    {
#if INCLUDE
        int[] numbers;
        numbers = {42, 84, 168 };
#endif // INCLUDE
    }

    // 3.
    static public void ArraySizeCannotBeSpecifiedInDataType()
    {
#if INCLUDE
        int[3] numbers = 
            { 42, 84, 168 };
#endif // INCLUDE
    }

    // 4.
    static public void ArraySizeOrInitializerIsRequired()
    {
#if INCLUDE
        int[] numbers =
            new int[];
#endif // INCLUDE
    }

    // 5.
    static public void ArraySizeWithEmptyInitializer()
    {
#if INCLUDE
        int[] numbers =
            new int[3] { };
#endif // INCLUDE
    }

    // 6.
    static public void IndexingOffTheEndOfArray()
    {
        int[] numbers =
            new int[3];
        Console.WriteLine(
          numbers[3]);
    }

    // 7.
    static public void Hat0IsOnePastTheEndOfTheArray1()
    {
        int[] numbers =
          new int[3];
        numbers[^0] = 42;
    }

    // 8.
    static public void LastItemIsLengthMinus1()
    {
        int[] numbers =
            new int[3];
        numbers[numbers.Length]
            = 42;
    }

    // 9.
    static public void MultiDimensionalArrayWithInconsistentSize()
    {
#if INCLUDE
        int[,] numbers =
          { {42}, {84, 42} };
#endif // INCLUDE
    }

    // 10.
    static public void MembersInJaggedArraysMustBeInstantiated()
    {
#if INCLUDE
        int[][] numbers = 
          { {42, 84}, {84, 42} };
#endif // INCLUDE
    }
}

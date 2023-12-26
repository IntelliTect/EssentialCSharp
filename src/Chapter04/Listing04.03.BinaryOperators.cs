// Justification: Checking for null isn't discussed yet.
#pragma warning disable CS8604 // Possible null reference argument
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_03;

public class Division
{
    public static void Main()
    {
        #region INCLUDE
        int numerator;
        int denominator;
        int quotient;
        int remainder;

        Console.Write("�������: ");
        numerator = int.Parse(Console.ReadLine());

        Console.Write("�����ĸ: ");
        denominator = int.Parse(Console.ReadLine());

        #region HIGHLIGHT
        quotient = numerator / denominator;  // ����
        remainder = numerator % denominator; // ȡ��
        #endregion HIGHLIGHT

        Console.WriteLine(
            $"{numerator} / {denominator} = ��{quotient}��{remainder}��");
        #endregion INCLUDE
    }
}
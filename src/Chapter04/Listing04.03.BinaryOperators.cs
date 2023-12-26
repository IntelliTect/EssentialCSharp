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

        Console.Write("输入分子: ");
        numerator = int.Parse(Console.ReadLine());

        Console.Write("输入分母: ");
        denominator = int.Parse(Console.ReadLine());

        #region HIGHLIGHT
        quotient = numerator / denominator;  // 除法
        remainder = numerator % denominator; // 取余
        #endregion HIGHLIGHT

        Console.WriteLine(
            $"{numerator} / {denominator} = 商{quotient}余{remainder}。");
        #endregion INCLUDE
    }
}
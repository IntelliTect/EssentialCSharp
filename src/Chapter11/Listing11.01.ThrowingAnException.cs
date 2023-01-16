namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_01;

using System;

#region INCLUDE
public sealed class TextNumberParser
{
    public static int Parse(string textDigit)
    {
        string[] digitTexts = 
            { "zero", "one", "two", "three", "four", 
              "five", "six", "seven", "eight", "nine" };

        int result = Array.IndexOf(
            digitTexts,
            // Leveraging C# 2.0’s null-coalescing operator
            (textDigit ??
              // Leveraging C# 7.0’s throw expression
              throw new ArgumentNullException(nameof(textDigit))
            ).ToLower());

        if (result < 0)
        {
            // Leveraging C# 6.0's nameof operator
            throw new ArgumentException(
                "The argument did not represent a digit", nameof(textDigit));
        }
        return result;
    }
}
#endregion INCLUDE

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_01
{
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
            #region EXCLUDE
            // If running with pre C# 7.0, you will have to use this
            // if (textDigit == null) throw new ArgumentNullException(nameof(textDigit));
            // int result = Array.IndexOf(
            //     digitTexts, textDigit?.ToLower());
            #endregion EXCLUDE

            if (result < 0)
            {
                // Leveraging C# 6.0's nameof operator
                throw new ArgumentException(
                    "The argument did not represent a digit", nameof(textDigit));
                #region EXCLUDE
                // If pre C# 6.0 will have to use this because the nameof operator doesn't exist yet
                // throw new ArgumentException(
                //     "The argument did not represent a digit",
                //     "textDigit");
                #endregion EXCLUDE
            }
            return result;
        }
    }
    #endregion INCLUDE
}
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_01
{
    using System;

    public sealed class TextNumberParser
    {
        public static int Parse(string textDigit)
        {
            string[] digitTexts = 
                { "zero", "one", "two", "three", "four", 
                  "five", "six", "seven", "eight", "nine" };

            int result = Array.IndexOf(
                digitTexts, textDigit.ToLower());

            if(result < 0)
            {
#if !PRECSHARP6
                throw new ArgumentException(
                    "The argument did not represent a digit", nameof(textDigit));
#else
                throw new ArgumentException(
                    "The argument did not represent a digit",
                    "textDigit");
#endif
            }

            return result;
        }
    }
}
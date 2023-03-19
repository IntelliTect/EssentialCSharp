namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_14;

using AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16;
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        KeywordProducts();
    }

    private static void KeywordProducts()
    {
        #region INCLUDE
        var numbers = new[] { 1, 2, 3 };
        IEnumerable<(string Word, int Number)> product =
             from word in CSharp.Keywords
                 #region HIGHLIGHT
             from number in numbers
                 #endregion HIGHLIGHT
             select (word, number);
        #endregion INCLUDE

        foreach ((string word, int number) in product)
        {
            Console.WriteLine(
                $"({word}, {number})");
        }
    }
}

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_13;

using AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16;
using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        KeywordCharacters();
    }

    private static void KeywordCharacters()
    {
        #region INCLUDE
        var selection =
            from word in CSharp.Keywords
                #region HIGHLIGHT
            from character in word
                #endregion HIGHLIGHT
            select character;
        #endregion INCLUDE

        foreach (var wordCharacter in selection)
        {
            Console.WriteLine(wordCharacter);
        }
    }
}

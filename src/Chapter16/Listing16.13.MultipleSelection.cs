namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_13
{
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
            var selection =
                from word in CSharp.Keywords
                from character in word
                select character;

            foreach(var wordCharacter in selection)
            {
                Console.WriteLine(wordCharacter);
            }
        }
    }
}

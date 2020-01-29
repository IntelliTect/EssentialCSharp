namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_01
{
    using AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            ShowContextualKeywords();
        }

        private static void ShowContextualKeywords()
        {
            IEnumerable<string> selection =
                from word in CSharp.Keywords
                where !word.Contains('*')
                select word;

            foreach(string keyword in selection)
            {
                Console.Write(keyword + " ");
            }
        }
    }
}
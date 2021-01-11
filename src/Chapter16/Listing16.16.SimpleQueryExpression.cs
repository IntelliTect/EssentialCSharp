namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_16
{
    using AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            ShowContextualKeywords1();
        }

        private static void ShowContextualKeywords1()
        {
            IEnumerable<string> selection =
                from word in CSharp.Keywords
                where !word.Contains('*')
                select word;

            foreach(var selectionWord in selection)
            {
                Console.WriteLine(Environment.NewLine + selectionWord);
            }
        }
    }
}

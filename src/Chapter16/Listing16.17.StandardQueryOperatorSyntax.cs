namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_17
{
    using AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            ShowContextualKeywords2();
        }

        private static void ShowContextualKeywords2()
        {
            IEnumerable<string> selection =
                CSharp.Keywords.Where(word => !word.Contains('*'));

            foreach(var selectionWord in selection)
            {
                Console.WriteLine(Environment.NewLine + "{0}",
                    selectionWord);
            }
        }
    }
}

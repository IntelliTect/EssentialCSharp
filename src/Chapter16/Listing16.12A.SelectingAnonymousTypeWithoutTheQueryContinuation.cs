namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_12A
{
    using AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16;
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            GroupKeywords1();
        }

        private static void GroupKeywords1()
        {
            var selection =
                from word in CSharp.Keywords
                group word by word.Contains('*')
                    into groups
                    select new
                    {
                        IsContextualKeyword = groups.Key,
                        Items = groups
                    };

            foreach(var wordGroup in selection)
            {
                Console.WriteLine(Environment.NewLine + "{0}:",
                    wordGroup.IsContextualKeyword ?
                        "Contextual Keywords" : "Keywords");
                foreach(var keyword in wordGroup.Items)
                {
                    Console.Write(" " +
                        keyword.Replace("*", null));
                }
            }
        }
    }
}

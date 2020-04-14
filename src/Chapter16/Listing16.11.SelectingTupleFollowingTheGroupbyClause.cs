namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_11
{
    using AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            GroupKeywords1();
        }

        private static void GroupKeywords1()
        {
            IEnumerable<IGrouping<bool, string>> keywordGroups =
                from word in CSharp.Keywords
                group word by word.Contains('*');

            IEnumerable<(bool IsContextualKeyword, IGrouping<bool, string> Items)> selection =
                from groups in keywordGroups
                select
                (
                    IsContextualKeyword: groups.Key,
                    Items: groups
                );


            foreach (
                (bool isContextualKeyword, IGrouping<bool, string> items) in selection)
            {

                Console.WriteLine(Environment.NewLine + "{0}:",
                    isContextualKeyword ?
                        "Contextual Keywords" : "Keywords");

                foreach (string keyword in items)
                {
                    Console.Write(" " + keyword.Replace("*", null));
                }
            }
        }
    }
}

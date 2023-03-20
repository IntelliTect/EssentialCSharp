namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_11;

using AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16;
#region INCLUDE
using System;
using System.Collections.Generic;
using System.Linq;
#region EXCLUDE
public class Program
{
    public static void Main()
    {
        GroupKeywords1();
    }
    #endregion EXCLUDE
    private static void GroupKeywords1()
    {
        #region HIGHLIGHT
        IEnumerable<IGrouping<bool, string>> keywordGroups =
            from word in CSharp.Keywords
            group word by word.Contains('*');

        IEnumerable<(bool IsContextualKeyword, 
            IGrouping<bool, string> Items)> selection =
            from groups in keywordGroups
            select
            (
                IsContextualKeyword: groups.Key,
                Items: groups
            );
        #endregion HIGHLIGHT

        foreach (
            (bool isContextualKeyword, IGrouping<bool, string> items)
                in selection)
        {

            Console.WriteLine(Environment.NewLine + "{0}:",
                isContextualKeyword ?
                    "Contextual Keywords" : "Keywords");
            #region HIGHLIGHT
            foreach (string keyword in items)
            #endregion HIGHLIGHT
            {
                Console.Write(" " + keyword.Replace("*", null));
            }
        }
    }
    //...
    #endregion INCLUDE
}

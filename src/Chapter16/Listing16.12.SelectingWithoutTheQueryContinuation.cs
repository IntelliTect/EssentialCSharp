namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_12;

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
        IEnumerable<(bool IsContextualKeyword, 
            IGrouping<bool, string> Items)> selection =
            from word in CSharp.Keywords
                #region HIGHLIGHT
            group word by word.Contains('*')
                into groups
                select
                (
                    IsContextualKeyword: groups.Key,
                    Items: groups
                );
        #endregion HIGHLIGHT
        #region EXCLUDE

        foreach ((bool isContextualKeyword, IGrouping<bool, string> items) in selection)
        {
            Console.WriteLine(Environment.NewLine + "{0}:",
                isContextualKeyword ?
                    "Contextual Keywords" : "Keywords");
            foreach(var keyword in items)
            {
                Console.Write(" " +
                    keyword.Replace("*", null));
            }
        }
        #endregion EXCLUDE
    }
    //...
    #endregion INCLUDE
}

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_10;

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
        IEnumerable<IGrouping<bool, string>> selection =
            from word in CSharp.Keywords
            group word by word.Contains('*');

        foreach(IGrouping<bool, string> wordGroup
            in selection)
        {
            Console.WriteLine(Environment.NewLine + "{0}:",
                wordGroup.Key ?
                    "Contextual Keywords" : "Keywords");
            foreach(string keyword in wordGroup)
            {
                Console.Write(" " +
                    (wordGroup.Key ?
                        keyword.Replace("*", null) : keyword));
            }
        }
    }
    //...
    #endregion INCLUDE
}

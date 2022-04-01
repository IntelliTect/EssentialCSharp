using System.Collections.ObjectModel;

#region INCLUDE
#region EXCLUDE
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16
{
    #endregion
    static public class CSharp
    {
        public static readonly ReadOnlyCollection<string> Keywords = new(
            new string[]
            {
                "abstract","add*","alias*","as","ascending*",
                "async*","await*","base","bool","break","by*","byte",
                "case","catch","char","checked","class","const",
                "continue","decimal","default","delegate",
                "descending*","do","double","dynamic*","else","enum",
                "equals*","event","explicit","extern","false","get*",
                "finally","fixed","float","for","foreach","from*",
                "global*","goto","group*","if","implicit","in","int",
                "interface","internal","into*","is","join*","let*","lock",
                "long", "nameof*", "namespace","new","nonnull*","null",
                "object","on*","operator","orderby*","out","override",
                "params","partial*","private","protected","public",
                "readonly","ref","remove*","return","sbyte","sealed",
                "select*","set*","short","sizeof","stackalloc","static",
                "string","struct","switch","this","throw","true","try",
                "typeof","uint","ulong","unchecked","unsafe","ushort",
                "using","value*","var*","virtual","void","volatile"
                ,"when*","where*","while","yield*"
            });
    }
    #region EXCLUDE
}

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_01
{
    using AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16;

    #endregion
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
            #region HIGHLIGHT
            IEnumerable<string> selection =
                from word in CSharp.Keywords
                where !word.Contains('*')
                select word;
            #endregion

            foreach (string keyword in selection)
            {
                Console.Write(keyword + " ");
            }
        }
    }
    #region EXCLUDE
}
#endregion
#endregion
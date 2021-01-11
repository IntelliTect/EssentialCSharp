using System.Collections.ObjectModel;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16
{
    static public class CSharp
    {
        public static readonly ReadOnlyCollection<string> Keywords = new ReadOnlyCollection<string>(
            new string[]
            {
                "abstract","add*","alias*","as","ascending*",
                "async*","await*","base","bool","break",
                "by*","byte","case","catch","char","checked",
                "class","const","continue","decimal","default",
                "delegate","descending*","do","double","dynamic*",
                "else","enum","equals*","event","explicit","extern",
                "false","finally","fixed","float","for","foreach",
                "from*","get*","global*","goto","group*","if","implicit",
                "in","int","interface","internal","into*","is","join*",
                "let*","lock","long", "nameof*", "namespace","new","nonnull*",
                "null","object","on*","operator","orderby*","out","override",
                "params","partial*","private","protected","public",
                "readonly","ref","remove*","return","sbyte","sealed",
                "select*","set*","short","sizeof","stackalloc","static",
                "string","struct","switch","this","throw","true","try",
                "typeof","uint","ulong","unchecked","unsafe","ushort",
                "using","value*","var*","virtual","void","volatile"
                ,"when*","where*","while","yield*"
            });
    }
}
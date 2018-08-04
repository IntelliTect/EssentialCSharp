namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            ShowContextualKeywords();
        }

        static string[] Keywords = {
            "abstract", "add*", "alias*", "as", "ascending*", 
            "async*", "await*", "base","bool", "break", 
            "by*", "byte", "case", "catch", "char", "checked",
            "class", "const", "continue", "decimal", "default",
            "delegate", "descending*", "do", "double",
            "dynamic*", "else", "enum", "event", "equals*", 
            "explicit", "extern", "false", "finally", "fixed", 
            "from*", "float", "for", "foreach", "get*", "global*", 
            "group*", "goto", "if", "implicit", "in", "int", 
            "into*", "interface", "internal", "is", "lock", "long", 
            "join*", "let*", "nameof*", "namespace", "new", "null",
            "object", "on*", "operator", "orderby*", "out", "override",
            "params", "partial*", "private", "protected",
            "public", "readonly", "ref", "remove*", "return", "sbyte",
            "sealed", "select*", "set*", "short", "sizeof",
            "stackalloc", "static", "string", "struct", "switch",
            "this", "throw", "true", "try", "typeof", "uint", "ulong",
            "unchecked", "unsafe", "ushort", "using", "value*", "var*",
            "virtual", "void", "volatile", "where*", "while", "yield*"
        };

        private static void ShowContextualKeywords()
        {
            IEnumerable<string> selection =
                from word in Keywords
                where !word.Contains('*')
                select word;

            foreach(string keyword in selection)
            {
                Console.Write(keyword + " ");
            }
        }
    }
}
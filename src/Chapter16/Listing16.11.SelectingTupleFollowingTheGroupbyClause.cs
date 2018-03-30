namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_11
{
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
                from word in Keywords
                group word by word.Contains('*');

            IEnumerable<(bool IsContextualKeyword, IGrouping<bool, string> Items)> selection =
                from groups in keywordGroups
                select
                (
                    IsContextualKeyword: groups.Key,
                    Items: groups
                );


            foreach (
                (bool IsContextualKeyword, IGrouping<bool, string> Items)
                    wordGroup in selection)
            {

                Console.WriteLine(Environment.NewLine + "{0}:",
                    wordGroup.IsContextualKeyword ?
                        "Contextual Keywords" : "Keywords");

                foreach (string keyword in wordGroup.Items)
                {
                    Console.Write(" " + keyword.Replace("*", null));
                }
            }
        }

        private static string[] Keywords = {
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
            "on*", "operator", "orderby*", "out", "override",
            "object", "params", "partial*", "private", "protected",
            "public", "readonly", "ref", "remove*", "return", "sbyte",
            "sealed", "select*", "set*", "short", "sizeof",
            "stackalloc", "static", "string", "struct", "switch",
            "this", "throw", "true", "try", "typeof", "uint", "ulong",
            "unsafe", "ushort", "using", "value*", "var*", "virtual",
            "unchecked", "void", "volatile", "where*", "while", "yield*"
        };
    }
}

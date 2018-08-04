namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_04
{
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
            IEnumerable<string> selection = from word in Keywords
                                            where IsKeyword(word)
                                            select word;
            Console.WriteLine("Query created.");
            foreach(string keyword in selection)
            {
                // No space output here
                Console.Write(keyword);
            }
        }

        // The side effect of console output is included 
        // in the predicate to demonstrate deferred execution;
        // predicates with side effects are a poor practice in
        // production code
        private static bool IsKeyword(string word)
        {
            if(word.Contains('*'))
            {
                Console.Write(" ");
                return true;
            }
            else
            {
                return false;
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
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_14
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            KeywordProducts();
        }

        private static void KeywordProducts()
        {
            var numbers = new[] { 1, 2, 3 };
            var product =
                 from word in Keywords
                 from number in numbers
                 select new { word, number };

            foreach(var value in product)
            {
                Console.WriteLine(Environment.NewLine + 
                    $"({value.word}, {value.number})");
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

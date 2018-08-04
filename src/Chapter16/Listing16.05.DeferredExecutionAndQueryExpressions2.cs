namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_05
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
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
            "unchecked", "void", "volatile", "where*", "while", "yield*" };
        
        public static void Main()
        {
            CountContextualKeywords();
        }

        private static void CountContextualKeywords()
        {
            int delegateInvocations = 0;
            Func<string, string> func =
                text =>
                {
                    delegateInvocations++;
                    return text;
                };

            IEnumerable<string> selection =
                from keyword in Keywords
                where keyword.Contains('*')
                select func(keyword);


            Console.WriteLine(
                $"1. delegateInvocations={ delegateInvocations }");

            // Executing count should invoke func once for 
            // each item selected
            Console.WriteLine(
                $"2. Contextual keyword count={ selection.Count() }");

            Console.WriteLine(
                $"3. delegateInvocations={ delegateInvocations }");

            // Executing count should invoke func once for 
            // each item selected
            Console.WriteLine(
                $"4. Contextual keyword count={ selection.Count() }");

            Console.WriteLine(
                $"5. delegateInvocations={ delegateInvocations }");

            // Cache the value so future counts will not trigger
            // another invocation of the query
            List<string> selectionCache = selection.ToList();

            Console.WriteLine(
                $"6. delegateInvocations={ delegateInvocations }");

            // Retrieve the count from the cached collection
            Console.WriteLine(
                $"7. selectionCache count={ selectionCache.Count() }");

            Console.WriteLine(
                $"8. delegateInvocations={ delegateInvocations }");
        }
    }
}

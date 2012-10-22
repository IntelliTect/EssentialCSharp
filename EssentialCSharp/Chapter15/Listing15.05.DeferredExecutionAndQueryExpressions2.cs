namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_05
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
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
                "1. delegateInvocations={0}", delegateInvocations);

            // Executing count should invoke func once for 
            // each item selected.
            Console.WriteLine(
                "2. Contextual keyword count={0}", selection.Count());

            Console.WriteLine(
                "3. delegateInvocations={0}", delegateInvocations);

            // Executing count should invoke func once for 
            // each item selected.
            Console.WriteLine(
                "4. Contextual keyword count={0}", selection.Count());

            Console.WriteLine(
                "5. delegateInvocations={0}", delegateInvocations);

            // Cache the value so future counts will not trigger
            // another invocation of the query.
            List<string> selectionCache = selection.ToList();

            Console.WriteLine(
                "6. delegateInvocations={0}", delegateInvocations);

            // Retrieve the count from the cached collection.
            Console.WriteLine(
                "7. selectionCache count={0}", selectionCache.Count());

            Console.WriteLine(
                "8. delegateInvocations={0}", delegateInvocations);

        }

        private static string[] Keywords = {
            "abstract", "add*", "alias*", "as", "ascending*", "base",
            "bool", "break", "by*", "byte", "case", "catch", "char",
            "checked", "class", "const", "continue", "decimal",
            "default", "delegate", "descending*", "do", "double",
            "dynamic*", "else", "enum", "event", "equals*",
            "explicit", "extern", "false", "finally", "fixed",
            "from*", "float", "for", "foreach", "get*", "global*",
            "group*", "goto", "if", "implicit", "in", "int",
            "into*", "interface", "internal", "is", "lock", "long",
            "join*", "let*", "namespace", "new", "null", "object",
            "on*", "operator", "orderby*", "out", "override",
            "params", "partial*", "private", "protected", "public",
            "readonly", "ref", "remove*", "return", "sbyte", "sealed",
            "select*", "set*", "short", "sizeof", "stackalloc",
            "static", "string", "struct", "switch", "this", "throw",
            "true", "try", "typeof", "uint", "ulong", "unchecked",
            "unsafe", "ushort", "using", "value*", "var*", "virtual",
            "void", "volatile", "where*", "while", "yield*"
        };
    }
}

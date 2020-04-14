namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_05
{
    using AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16;
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
            string func(string text)
            {
                delegateInvocations++;
                return text;
            }

            IEnumerable<string> selection =
                from keyword in CSharp.Keywords
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

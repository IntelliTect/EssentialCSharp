namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_04
{
    using AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16;
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
            IEnumerable<string> selection = from word in CSharp.Keywords
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
    }
}
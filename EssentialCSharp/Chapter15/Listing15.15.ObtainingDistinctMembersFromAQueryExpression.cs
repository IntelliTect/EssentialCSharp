using System.Collections.Generic;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_15
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            ListMemberNames();
        }

        public static void ListMemberNames()
        {
            IEnumerable<string> enumerableMethodNames = (
                from method in typeof(Enumerable).GetMembers(
                    System.Reflection.BindingFlags.Static |
                    System.Reflection.BindingFlags.Public)
                select method.Name).Distinct();
            foreach (string method in enumerableMethodNames)
            {
                Console.Write(" {0},", method);
            }
        }
    }
}

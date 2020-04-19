

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_15
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

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
                    orderby method.Name
                    select method.Name).Distinct();
            foreach(string method in enumerableMethodNames)
            {
                Console.Write($"{ method }, ");
            }
        }
    }
}

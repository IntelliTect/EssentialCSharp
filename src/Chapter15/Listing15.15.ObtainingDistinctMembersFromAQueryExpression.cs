using System.Collections.Generic;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_15
{
    using System;
    using System.Linq;
    using System.Reflection;

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

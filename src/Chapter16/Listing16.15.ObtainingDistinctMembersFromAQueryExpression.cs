namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_15;

#region INCLUDE
using System;
using System.Linq;
using System.Collections.Generic;
#region EXCLUDE
public class Program
{
    public static void Main()
    {
        ListMemberNames();
    }
    #endregion EXCLUDE
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
    //...
    #endregion INCLUDE
}

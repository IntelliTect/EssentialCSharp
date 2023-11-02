
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_15.Tests;

[TestClass]
public class ProgramTests
{
    public TestContext TestContext { get; set; } = null!; // Assigned by MSTest.

    [TestMethod]
    public void SelectingAnonymousTypeFollowingGroupClause()
    {
        string dotnetCoreVersion = Shared.NetCore.GetNetCoreVersion();
        string expected = dotnetCoreVersion switch
        {
            // Version <= 5
            string value when string.Compare(value, "6")<0 => """
                        Aggregate, All, Any, Append, AsEnumerable, Average, Cast, Concat, Contains, 
                        Count, DefaultIfEmpty, Distinct, ElementAt, ElementAtOrDefault, Empty, 
                        Except, First, FirstOrDefault, GroupBy, GroupJoin, Intersect, Join, Last, 
                        LastOrDefault, LongCount, Max, Min, OfType, OrderBy, OrderByDescending, 
                        Prepend, Range, Repeat, Reverse, Select, SelectMany, SequenceEqual, 
                        Single, SingleOrDefault, Skip, SkipLast, SkipWhile, Sum, Take, TakeLast, TakeWhile, ThenBy, 
                        ThenByDescending, ToArray, ToDictionary, ToHashSet, ToList, ToLookup, Union, Where, Zip, 
                        """,
            // Version 6
            string value when value.StartsWith("6") => """
                    Aggregate, All, Any, Append, AsEnumerable, Average, Cast, 
                    Chunk, Concat, Contains, Count, DefaultIfEmpty, Distinct, DistinctBy, 
                    ElementAt, ElementAtOrDefault, Empty, Except, ExceptBy, First, 
                    FirstOrDefault, GroupBy, GroupJoin, Intersect, IntersectBy, Join, 
                    Last, LastOrDefault, LongCount, Max, MaxBy, Min, MinBy, OfType, 
                    OrderBy, OrderByDescending, Prepend, Range, Repeat, Reverse, 
                    Select, SelectMany, SequenceEqual, Single, SingleOrDefault, Skip, 
                    SkipLast, SkipWhile, Sum, Take, TakeLast, TakeWhile, ThenBy, 
                    ThenByDescending, ToArray, ToDictionary, ToHashSet, ToList, 
                    ToLookup, TryGetNonEnumeratedCount, Union, UnionBy, Where, Zip, 
                    """,
            // Version 7
            _ => """
                    Aggregate, All, Any, Append, AsEnumerable, Average, Cast, 
                    Chunk, Concat, Contains, Count, DefaultIfEmpty, Distinct, DistinctBy, 
                    ElementAt, ElementAtOrDefault, Empty, Except, ExceptBy, First, 
                    FirstOrDefault, GroupBy, GroupJoin, Intersect, IntersectBy, Join, 
                    Last, LastOrDefault, LongCount, Max, MaxBy, Min, MinBy, OfType, 
                    Order, OrderBy, OrderByDescending, OrderDescending, Prepend, Range, 
                    Repeat, Reverse, Select, SelectMany, SequenceEqual, Single, 
                    SingleOrDefault, Skip, SkipLast, SkipWhile, Sum, Take, TakeLast, 
                    TakeWhile, ThenBy, ThenByDescending, ToArray, ToDictionary, ToHashSet, 
                    ToList, ToLookup, TryGetNonEnumeratedCount, Union, UnionBy, Where, Zip, 
                    """
        };

        TestContext.WriteLine(dotnetCoreVersion);

        expected = expected.Replace("\r\n", string.Empty);
        expected = expected.Replace("\n", string.Empty);
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, Program.Main);
    }
}

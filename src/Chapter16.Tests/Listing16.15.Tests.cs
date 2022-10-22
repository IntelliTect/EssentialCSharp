using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_15.Tests
{
    [TestClass]
    public class ProgramTests
    {
        public TestContext TestContext { get; set; } = null!; // Assigned by MSTest.

        [TestMethod]
        public void SelectingAnonymousTypeFollowingGroupClause()
        {
            string e = Shared.NetCore.GetNetCoreVersion() switch
            {
                string value when string.Compare(value, "6")<0 => """
                        Aggregate, All, Any, Append, AsEnumerable, Average, Cast, Concat, Contains, 
                        Count, DefaultIfEmpty, Distinct, ElementAt, ElementAtOrDefault, Empty, 
                        Except, First, FirstOrDefault, GroupBy, GroupJoin, Intersect, Join, Last, 
                        LastOrDefault, LongCount, Max, Min, OfType, OrderBy, OrderByDescending, 
                        Prepend, Range, Repeat, Reverse, Select, SelectMany, SequenceEqual, 
                        Single, SingleOrDefault, Skip, SkipLast, SkipWhile, Sum, Take, TakeLast, TakeWhile, ThenBy, 
                        ThenByDescending, ToArray, ToDictionary, ToHashSet, ToList, ToLookup, Union, Where, Zip, 
                        """,
                string value when string.Compare(value, "7")<0 => """
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
                // Version 7.0
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


            // New lines added for output formatting in the chapter.
            string expected = """
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
                    """;

            TestContext.WriteLine(Shared.NetCore.GetNetCoreVersion());
            if (string.Compare(Shared.NetCore.GetNetCoreVersion(), "7") < 0)
            {
                expected = """
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
                    """;

                if (string.Compare(Shared.NetCore.GetNetCoreVersion(), "5") < 0)
                {
                    expected = """
                        Aggregate, All, Any, Append, AsEnumerable, Average, Cast, Concat, Contains, 
                        Count, DefaultIfEmpty, Distinct, ElementAt, ElementAtOrDefault, Empty, 
                        Except, First, FirstOrDefault, GroupBy, GroupJoin, Intersect, Join, Last, 
                        LastOrDefault, LongCount, Max, Min, OfType, OrderBy, OrderByDescending, 
                        Prepend, Range, Repeat, Reverse, Select, SelectMany, SequenceEqual, 
                        Single, SingleOrDefault, Skip, SkipLast, SkipWhile, Sum, Take, TakeLast, TakeWhile, ThenBy, 
                        ThenByDescending, ToArray, ToDictionary, ToHashSet, ToList, ToLookup, Union, Where, Zip, 
                        """;
                }
            }

            expected = expected.Replace("\r\n", string.Empty);
            expected = expected.Replace("\n", string.Empty);
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, Program.Main);
        }
    }
}

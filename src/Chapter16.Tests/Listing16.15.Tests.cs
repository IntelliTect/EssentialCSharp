using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_15.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void SelectingAnonymousTypeFollowingGroupClause()
        {
            // New lines added for output formatting in the chapter.
            string expected =
@"Aggregate, All, Any, Append, AsEnumerable, Average, Cast, Concat, Contains, 
Count, DefaultIfEmpty, Distinct, ElementAt, ElementAtOrDefault, Empty, 
Except, First, FirstOrDefault, GroupBy, GroupJoin, Intersect, Join, Last, 
LastOrDefault, LongCount, Max, Min, OfType, OrderBy, OrderByDescending, 
Prepend, Range, Repeat, Reverse, Select, SelectMany, SequenceEqual, 
Single, SingleOrDefault, Skip, SkipLast, SkipWhile, Sum, Take, TakeLast, TakeWhile, ThenBy, 
ThenByDescending, ToArray, ToDictionary, ToHashSet, ToList, ToLookup, Union, Where, Zip, ";

            expected = expected.Replace("\r\n", string.Empty);
            expected = expected.Replace("\n", string.Empty);
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, Program.Main);
        }
    }
}

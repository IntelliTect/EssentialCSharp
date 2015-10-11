using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_15.Tests
{
    using System;

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void SelectingAnonymousTypeFollowingGroupClause()
        {
            // New lines added for output formatting in the chapter.
            string expected =
@"Aggregate, All, Any, AsEnumerable, Average, Cast, Concat, Contains, 
Count, DefaultIfEmpty, Distinct, ElementAt, ElementAtOrDefault, 
Empty, Except, First, FirstOrDefault, GroupBy, GroupJoin, 
Intersect, Join, Last, LastOrDefault, LongCount, Max, Min, OfType, 
OrderBy, OrderByDescending, Range, Repeat, Reverse, Select, 
SelectMany, SequenceEqual, Single, SingleOrDefault, Skip, 
SkipWhile, Sum, Take, TakeWhile, ThenBy, ThenByDescending, ToArray, 
ToDictionary, ToList, ToLookup, Union, Where, Zip, ";

            expected = expected.Replace(Environment.NewLine, "");

            IntelliTect.ConsoleView.Tester.Test(
                expected, Program.Main);
        }
    }
}
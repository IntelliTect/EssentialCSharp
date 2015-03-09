using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_15.Tests
{

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void SelectingAnonymousTypeFollowingGroupClause()
        {
            string expected = @"Where,Select,SelectMany,Take,TakeWhile,Skip,SkipWhile,Join,GroupJoin,OrderBy,OrderByDescending,ThenBy,ThenByDescending,GroupBy,Concat,Zip,Distinct,Union,Intersect,Except,Reverse,SequenceEqual,AsEnumerable,ToArray,ToList,ToDictionary,ToLookup,DefaultIfEmpty,OfType,Cast,First,FirstOrDefault,Last,LastOrDefault,Single,SingleOrDefault,ElementAt,ElementAtOrDefault,Range,Repeat,Empty,Any,All,Count,LongCount,Contains,Aggregate,Sum,Min,Max,Average,";

			IntelliTect.ConsoleView.Tester.Test(expected,
            () =>
            {
				Program.Main();
            });
        }
    }
}
using AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_12.Tests
{

    [TestClass]
    public class ProgramTests
    {

        [TestMethod]
        public void SelectingFollowingGroupClause_UsingTuple()
        {
            SelectingFollowingGroupClause(Listing16_12.Program.Main);
        }

        public void SelectingFollowingGroupClause(Action _)
        {
            string expected = $@"
Keywords:
 { CSharpExpectedData.ExpectedKeywords }
Contextual Keywords:
 { CSharpExpectedData.ExpectedContextualKeywords }";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            () =>
            {
                Program.Main();
            });
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System;
using AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_13.Tests
{

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void SelectingAnonymousTypeFollowingGroupClause()
        {
            // Intentionally use something other than select to 
            // determine the result.
            string expected = CSharp.Keywords.Aggregate("",
                (string result, string word) => {
                    var splitCharactersOntoEachLine = word.Aggregate("",
                (string wordResult, char character) =>
                    wordResult + character + Environment.NewLine);
                    return result + splitCharactersOntoEachLine;
            });

            string nl = Environment.NewLine;
            Assert.IsTrue(
                expected.StartsWith($"a{nl}b{nl}s{nl}t{nl}r{nl}a{nl}c{nl}t{nl}a"));
            Assert.IsTrue(
                expected.EndsWith($"e{nl}y{nl}i{nl}e{nl}l{nl}d{nl}*{nl}"));


            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            () =>
            {
                Program.Main();
            });
        }
    }
}
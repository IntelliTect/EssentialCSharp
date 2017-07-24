using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_14.Tests
{

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void SelectingAnonymousTypeFollowingGroupClause()
        {
            string expected = $@"(abstract, 1)
(abstract, 2)
(abstract, 3)
(add\*, 1)
(add\*, 2)
(add\*, 3)
(alias\*, 1)
*
(where\*, 3)
(while, 1)
(while, 2)
(while, 3)
(yield\*, 1)
(yield\*, 2)
(yield\*, 3)";
    


            IntelliTect.TestTools.Console.ConsoleAssert.ExpectLike(expected, '\\',
            () =>
            {
                Program.Main();
            });
        }
    }
}

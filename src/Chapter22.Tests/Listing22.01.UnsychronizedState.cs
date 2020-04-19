using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_01.Tests
{
    [TestClass]
    public class ProgramTests
    {
        public static bool IsIncrementDecrementLikelySynchronized(
            Func<string[], int> func, long iterations)
        {
            string[] args = { iterations.ToString() };
            return func(args) == 0;
        }


        /// <summary>
        /// Returns true if the increment/decrement operations are not atomic.
        /// 
        /// IMPORTANT: This method does not prove something is atomic.  It returns
        /// true if they are not atomic.  A return of false indicates atomicity is unknown.
        /// </summary>
        /// <param name="func"></param>
        /// <returns></returns>
        public static bool IsIncrementDecrementNotAtomic(
            Func<string[], int> func)
        {
            bool unsyncrhonized = false;
            
            string[] count = { "10000000" };

            if (func(count) != 0)
            {
                unsyncrhonized = true;
            }

            return unsyncrhonized;
        }

        static public void VerifyOutputIncrementAndDecrement(Func<string[], int> main)
        {
            int? result = null;
            string expected = $"Increment and decrementing \\d+ times...{Environment.NewLine}Count = (?<Count>\\d*)";
            string output = IntelliTect.TestTools.Console.ConsoleAssert.Execute("",
            () =>
            {
                result = main(new string[] { "1" });
            });
            MatchCollection matches = Regex.Matches(output, expected, System.Text.RegularExpressions.RegexOptions.Multiline);
            Assert.IsTrue(matches.Count > 0);
            Assert.IsTrue(matches[0].Success);
            Assert.AreEqual(result.ToString(), matches[0].Groups["Count"].Value);
        }


        [TestMethod]
        public void MainVerifyOutputIncrementAndDecrement()
        {
            VerifyOutputIncrementAndDecrement(Program.Main);
        }

        /// <summary>
        /// Indicates that a the increment/decrement operations are not atomic
        /// IMPORTANT: Returns Inconclusive as it may just happen to increment/decrement 
        /// consistently but that doesn't prove that it is synchronized (which is not reasonably
        /// possible to prove with code execution).
        /// </summary>      
        [TestMethod]
        public void UnsynchronizedIncrementAndDecrement()
        {
            bool isUnsynchronized = IsIncrementDecrementNotAtomic(Program.Main);
            if (!isUnsynchronized)
            {
                Assert.Inconclusive("Unexpectedly, the number of increments and decrements was the same even though there was no lock mechanism.");
            }
        }
    }
}

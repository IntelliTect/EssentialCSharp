using Microsoft.VisualStudio.TestTools.UnitTesting;
using static AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_01.Tests.ProgramTests;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_02
{
    [TestClass]
    public class ProgramTests
    {

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

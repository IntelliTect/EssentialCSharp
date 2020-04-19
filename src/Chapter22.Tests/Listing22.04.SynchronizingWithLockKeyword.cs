using Microsoft.VisualStudio.TestTools.UnitTesting;
using static AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_01.Tests.ProgramTests;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_04
{

    [TestClass]
    public class ProgramTests
    {

        [TestMethod]
        public void SynchronizedIncrementAndDecrement()
        {
            Assert.IsTrue(
                IsIncrementDecrementLikelySynchronized(Program.Main, short.MaxValue));
        }

    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using static AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_01.Tests.ProgramTests;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_05
{

    [TestClass]
    public class ProgramTests
    {

        [TestMethod]
        public void SynchronizedIncrementAndDecrement()
        {
            Assert.IsTrue(IsIncrementDecrementLikelySynchronized(
                (args)=>Program.Main(args).Result, short.MaxValue));
        }

    }
}

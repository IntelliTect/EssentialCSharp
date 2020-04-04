using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_01.Tests.ProgramTests;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_05.Tests
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

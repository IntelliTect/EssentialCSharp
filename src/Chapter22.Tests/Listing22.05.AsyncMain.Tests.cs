using static AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_01.Tests.ProgramTests;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_05.Tests;

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

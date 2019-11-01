using AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_13to14.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_13.Tests
{

    [TestClass]
    public class ProgramTests : BaseProgramTests
    {
       [ClassInitialize]
       static public void ClassInitialize(TestContext textContext)
        {
            ProgramWrapper = new ProgramWrapper(Program.Main);
        }
    }
}

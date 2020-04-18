using AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Threading.Tasks;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_01.Tests
{

    [TestClass]
    public class ProgramTests : BaseProgramTests
    {
       [ClassInitialize]
       static public void ClassInitialize(TestContext _)
        {
            ProgramWrapper = new ProgramWrapper(
                (args)=>
                    Task.Run(() => Program.Main(args)));
        }
    }
}

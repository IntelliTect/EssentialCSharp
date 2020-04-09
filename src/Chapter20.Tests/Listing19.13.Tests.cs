using AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_01.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
                    new ValueTask(Task.Run(() => Program.Main(args))), 
                (findText, url, progress) => 
                    Task.Run(()=>Program.FindTextInWebUri(findText, url.First())));
        }
    }
}

using AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_13to14.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_13.Tests
{

    [TestClass]
    public class ProgramTests : BaseProgramTests
    {
       [ClassInitialize]
       static public void ClassInitialize(TestContext textContext)
        {
            ProgramWrapper = new ProgramWrapper(
                (args)=>
                    new ValueTask(Task.Run(() => Program.Main(args))), 
                (findText, url, progress) => 
                    Task.Run(()=>Program.FindTextInWebUri(findText, url.First())));
        }
    }
}

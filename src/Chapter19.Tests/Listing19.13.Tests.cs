using AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_13to14.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_13.Tests
{

    [TestClass]
    public class ProgramTests : BaseProgramTests<int>
    {
       [ClassInitialize]
       static public void ClassInitialize(TestContext textContext)
        {
            ProgramWrapper = new ProgramWrapper<int>(Program.Main, (url, findText, progress) => Program.FindTextInWebUri(url, findText));
        }
    }
}

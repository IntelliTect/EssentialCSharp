using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_04.Tests
{
    using static Listing19_03.Tests.ProgramTests;

    [TestClass]
    public class ProgramTests
    {

        [TestMethod]
        public void Unsynchronized()
        {
            TestUnsychronizedIncrementDecrement(Program.Main);
        }

    }
}

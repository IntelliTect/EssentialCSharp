using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_05.Tests
{
    using static Listing20_03.Tests.ProgramTests;

    [TestClass]
    public class ProgramTests
    {

        [TestMethod]
        public void Unsynchronized()
        {
            TestUnsychronizedIncrementDecrement(()=>Program.Main().Wait());
        }

    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_23.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void SaveWithDataTest()
        {
            Listing06_22.Tests.ProgramTests.SaveWithData(Program.Save);
        }

        [TestMethod][ExpectedException(typeof(ArgumentNullException))]
        public void SaveWithNullTest()
        {
            Listing06_22.Tests.ProgramTests.SaveWithNull(Program.Save);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_23.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void SaveWithDataTest()
        {
            Listing07_22.Tests.ProgramTests.SaveWithData(Program.Save);
        }

        [TestMethod][ExpectedException(typeof(ArgumentNullException))]
        public void SaveWithNullTest()
        {
            Listing07_22.Tests.ProgramTests.SaveWithNull(Program.Save);
        }
    }
}
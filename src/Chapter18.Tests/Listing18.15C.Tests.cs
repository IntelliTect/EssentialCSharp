using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_15C.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void AsyncVoidReturnTest()
        {
            bool ExceptionCaught = false;
            try
            {
                //string expected = "";
                //IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
                //() =>
                //{
                //});

                Program.Main();
            }
            catch(Exception ex) when (ex.Message == Program.ExpectedExceptionMessage)
            {
                ExceptionCaught = true;
            }

            Assert.IsTrue(ExceptionCaught);
        }
    }
}

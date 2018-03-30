using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_22.Tests
{
    [TestClass]
    public class ProgramTests
    {
        static public void SaveWithData(Action<string> target)
        {
            string data = "My name is Inigo Montoya.  You killed my father. Prepare to die.";
            string expected = $"ENCRYPTED <{data}> ENCRYPTED";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, () => target(data)
            );
        }

        [TestMethod]
        public void SaveWithDataTest()
        {
            SaveWithData(Program.Save);
        }


        static public void SaveWithNull(Action<string> targetTest)
        {
            string expected = $"Warning: Nothing to save{Environment.NewLine}";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, ()=>targetTest(null)
            );
        }

        [TestMethod][ExpectedException(typeof(ArgumentNullException))]
        public void SaveWithNullTest()
        {
            SaveWithNull(Program.Save);
        }
    }
}
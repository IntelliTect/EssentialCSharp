using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_24.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void EjectDvd()
        {
            string expected = $"Ejecting the DVD...{Environment.NewLine}DVD Ejected!";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, () =>
                {
                    Program.Eject(new Dvd() { IsInserted = true });
                }
            );
        }

        [TestMethod]
        public void EjectUsb()
        {
            string expected = $"Unloading the UsbKey...{Environment.NewLine}USB Drive Unloaded!";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, () =>
                    Program.Eject(new UsbKey() { IsPluggedIn = true })
            );
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void EjectHardDrive()
        {
            string expected = $"Warning: Nothing to save{Environment.NewLine}";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, () =>
                    Program.Eject(new HardDrive())
            );
        }

        [TestMethod][ExpectedException(typeof(ArgumentNullException))]
        public void EjectNull()
        {
            string expected = $"Warning: Nothing to save{Environment.NewLine}";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, () =>
                    Program.Eject(null)
            );
        }
    }
}
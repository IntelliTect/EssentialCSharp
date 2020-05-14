﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Chapter10.Tests.CustomTestAttributes;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_13.Tests
{
    [TestClass]
    public class TypeTests
    {

        [TestMethodWithIgnoreIfSupport]
        [IgnoreIf(nameof(NotWindows))]
        public void MakingTypesAvailableExternallyPS1_ExitCodeIs0()
        {
            //EssentialCSharp\\src\\Chapter10.Tests\\bin\\Debug\\netcoreapp3.0
            string ps1Path = Path.GetFullPath("../../../../Chapter10/Listing10.13.MakingTypesAvailableExternally.ps1", Environment.CurrentDirectory);
            string traceValue = "0";

            System.Diagnostics.Process powerShell = System.Diagnostics.Process.Start("powershell", $"-noprofile -command \"{ps1Path} {traceValue}\"");
            powerShell.WaitForExit();

            Assert.AreEqual(0, powerShell.ExitCode);
        }

        private static bool NotWindows()
        {
            return !RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
        }

    }
}


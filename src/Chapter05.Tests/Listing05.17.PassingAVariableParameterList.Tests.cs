using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_17.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_WritePath()
        {
            string view = Path.Combine(Directory.GetCurrentDirectory(), "bin", "config", "index.html");
            view += Environment.NewLine;
            view += Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).FullName, "Temp", "index.html");
            view += Environment.NewLine;
            view += $"C:{Path.DirectorySeparatorChar}{Path.Combine("Data", "HomeDir", "index.html")}";




//            string view =
//Directory.GetCurrentDirectory() + @"\bin\config\index.html
//" + Directory.GetParent(Directory.GetCurrentDirectory()).FullName + @"\Temp\index.html
//C:\Data\HomeDir\index.html";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(view,
            () =>
            {
                Program.Main();
            });
        }
    }
}
using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_14.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_WritePath()
        {
            string view =
Directory.GetCurrentDirectory() + @"\bin\config\index.html
" + Directory.GetParent(Directory.GetCurrentDirectory()).FullName + @"\Temp\index.html
C:\Data\HomeDir\index.html";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(view,
            () =>
            {
                Program.ChapterMain();
            });
        }
    }
}
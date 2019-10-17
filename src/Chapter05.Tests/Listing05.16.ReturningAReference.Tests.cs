using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_16.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_InputInigoMontoya_WriteFullName()
        {
            string view = @"image\[*\]=Red
image\[*\]=Black";

            IntelliTect.TestTools.Console.ConsoleAssert.ExpectLike(view,
            () =>
            {
                Program.Main();
            });
        }
    }
}
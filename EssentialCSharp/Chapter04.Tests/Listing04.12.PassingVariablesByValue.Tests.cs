using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_11.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_WritePath()
        {
            string view = "C:\\Data\\index.html";

            IntelliTect.ConsoleView.Tester.Test(view,
            () =>
            {
                Program.Main();
            });
        }
    }
}
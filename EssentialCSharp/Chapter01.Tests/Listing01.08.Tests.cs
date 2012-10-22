using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_08.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_HelloToInigo()
        {
            string view = @"Hello Inigo Montoya";

            IntelliTect.ConsoleView.Tester.Test(view,
            () =>
            {
                Program.Main();
            });
        }
    }
}
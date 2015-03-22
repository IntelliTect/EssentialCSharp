using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_25.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_ExamingingAnExpressTree()
        {
            string expected =
            @"------------- (x, y) => (x > y) -------------
     x (Parameter)
>
     y (Parameter)


------------- (x, y) => ((x * y) > (x + y)) -------------
          x (Parameter)
     *
          y (Parameter)
>
          x (Parameter)
     +
          y (Parameter)";

            IntelliTect.ConsoleView.Tester.Test(expected,
            () =>
            {
                Program.Main();
            });
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_25.Tests
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

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            () =>
            {
                Program.Main();
            });
        }
    }
}
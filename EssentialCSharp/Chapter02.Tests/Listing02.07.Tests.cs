using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_07.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_WriteBooleanStatements()
        {
            string view =
@"True: result != number
True: result == number";

            IntelliTect.ConsoleView.Tester.Test(view,
            () =>
            {
                Program.Main();
            });
        }
    }
}
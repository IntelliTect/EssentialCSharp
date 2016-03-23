using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_17.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void IteratingAbinaryTree()
        {
            const string expected =
                @"John Fitzgerald Kennedy
Joseph Patrick Kennedy
Patrick Joseph Kennedy
Mary Augusta Hickey
Rose Elizabeth Fitzgerald
John Francis Fitzgerald
Mary Josephine Hannon";

            IntelliTect.ConsoleView.Tester.Test(expected,
                () => Program.Main());
        }
    }
}
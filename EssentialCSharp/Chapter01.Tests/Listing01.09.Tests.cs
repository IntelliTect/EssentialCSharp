using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_09.Tests
{
    [TestClass]
    public class MiracleMaxTests
    {
        [TestMethod]
        public void Main_StormCastleShort()
        {
            const string expected = @"Have fun storming the castle!";

            IntelliTect.ConsoleView.Tester.Test(
                expected, MiracleMax.ChapterMain);
        }
    }
}
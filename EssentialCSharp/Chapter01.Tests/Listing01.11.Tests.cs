using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_11.Tests
{
    [TestClass]
    public class MiracleMaxTests
    {
        [TestMethod]
        public void Main_StormCastleLong()
        {
            const string expected =
@"Have fun storming the castle!
Think it will work?
It would take a miracle.";

            IntelliTect.ConsoleView.Tester.Test(
                expected, MiracleMax.ChapterMain);
        }
    }
}
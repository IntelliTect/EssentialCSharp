using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_10.Tests
{
    [TestClass]
    public class MiracleMaxTests
    {
        [TestMethod]
        public void Main_StormCastleShort()
        {
            const string expected = @"Have fun storming the castle!";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, MiracleMax.Main);
        }
    }
}